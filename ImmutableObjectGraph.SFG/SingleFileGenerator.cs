﻿namespace Microsoft.ImmutableObjectGraph_SFG
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.CodeAnalysis.Formatting;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.ComponentModelHost;
    using Microsoft.VisualStudio.LanguageServices;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.Shell.Interop;
    using Validation;

    [ComVisible(true)]
    [Guid("163AA075-225C-4797-9019-FEB55E5CB392")]
    public class SingleFileGenerator : IVsSingleFileGenerator
    {
        private const string GeneratedByAToolPreamble = @"// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
";

        public int DefaultExtension(out string pbstrDefaultExtension)
        {
            pbstrDefaultExtension = ".generated.cs";
            return VSConstants.S_OK;
        }

        public int Generate(string inputFilePath, string inputFileContents, string defaultNamespace, IntPtr[] outputFileContents, out uint outputLength, IVsGeneratorProgress generateProgress)
        {
            if (outputFileContents != null && outputFileContents.Length > 0)
            {
                // Do this first, before input validation, so that the
                // catch block doesn't try to free memory with an uninitialized pointer.
                outputFileContents[0] = IntPtr.Zero;
            }

            try
            {
                Requires.NotNullOrEmpty(inputFilePath, "inputFilePath");
                Requires.NotNull(outputFileContents, "outputFileContents");
                Requires.Argument(outputFileContents.Length > 0, "outputFileContents", "Non-empty array expected.");

                string generated = null;
                ThreadHelper.JoinableTaskFactory.Run(async delegate
                {
                    IVsUIHierarchy uiHierarchy;
                    uint itemid;
                    GetSourceProjectItem(inputFilePath, out uiHierarchy, out itemid);
                    object projectNameObject;
                    ErrorHandler.ThrowOnFailure(uiHierarchy.GetProperty((uint)VSConstants.VSITEMID.Root, (int)__VSHPROPID.VSHPROPID_Name, out projectNameObject));

                    VisualStudioWorkspace workspace = GetRoslynWorkspace();
                    var inputDocumentId = workspace.CurrentSolution.GetDocumentIdsWithFilePath(inputFilePath).First();
                    var inputDocument = workspace.CurrentSolution.GetDocument(inputDocumentId);
                    var inputSemanticModel = await inputDocument.GetSemanticModelAsync();
                    var inputSyntaxTree = inputSemanticModel.SyntaxTree;

                    var inputFileLevelUsingDirectives = inputSyntaxTree.GetRoot().ChildNodes().OfType<UsingDirectiveSyntax>();

                    var memberNodes = from syntax in inputSyntaxTree.GetRoot().DescendantNodes(n => n is CompilationUnitSyntax || n is NamespaceDeclarationSyntax || n is TypeDeclarationSyntax).OfType<MemberDeclarationSyntax>()
                                      select syntax;

                    var emittedMembers = new List<MemberDeclarationSyntax>();
                    foreach (var memberNode in memberNodes)
                    {
                        var namespaceNode = memberNode.Parent as NamespaceDeclarationSyntax;

                        var generationAttributesSymbols = FindCodeGenerationAttributes(
                            inputSemanticModel,
                            memberNode);
                        foreach (var generationAttributeSymbol in generationAttributesSymbols)
                        {
                            var generationAttribute = (CodeGenerationAttribute)Instantiate(generationAttributeSymbol, inputSemanticModel.Compilation);
                            if (generationAttribute != null)
                            {
                                var generatedType = await generationAttribute.GenerateAsync(memberNode, inputDocument, CancellationToken.None);
                                if (namespaceNode != null)
                                {
                                    generatedType = SyntaxFactory.NamespaceDeclaration(namespaceNode.Name)
                                        .WithMembers(SyntaxFactory.List(new[] { generatedType }));
                                }

                                emittedMembers.Add(generatedType);
                            }
                        }
                    }

                    var emittedTree = SyntaxFactory.CompilationUnit()
                        .WithUsings(SyntaxFactory.List(inputFileLevelUsingDirectives))
                        .WithMembers(SyntaxFactory.List(emittedMembers))
                        .WithLeadingTrivia(SyntaxFactory.Comment(GeneratedByAToolPreamble));

                    generated = Formatter.Format(emittedTree, workspace, workspace.Options).ToFullString();
                });

                // Translate the string we've built up into the bytes of COM memory required.
                var encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
                byte[] bytes = encoding.GetBytes(generated);
                outputLength = (uint)bytes.Length;
                outputFileContents[0] = Marshal.AllocCoTaskMem(bytes.Length);
                Marshal.Copy(bytes, 0, outputFileContents[0], bytes.Length);

                return VSConstants.S_OK;
            }
            catch (Exception ex)
            {
                if (outputFileContents[0] != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(outputFileContents[0]);
                    outputFileContents[0] = IntPtr.Zero;
                }

                outputLength = 0;
                return Marshal.GetHRForException(ex);
            }
        }

        private static IEnumerable<AttributeData> FindCodeGenerationAttributes(SemanticModel document, SyntaxNode nodeWithAttributesApplied)
        {
            Requires.NotNull(document, "document");
            Requires.NotNull(nodeWithAttributesApplied, "nodeWithAttributesApplied");

            var symbol = document.GetDeclaredSymbol(nodeWithAttributesApplied);
            if (symbol != null)
            {
                foreach (var attribute in symbol.GetAttributes())
                {
                    if (IsOrDerivesFromCodeGenerationAttribute(attribute.AttributeClass))
                    {
                        yield return attribute;
                    }
                }
            }
        }

        private static bool IsOrDerivesFromCodeGenerationAttribute(INamedTypeSymbol type)
        {
            if (type != null)
            {
                if (type.Name == typeof(CodeGenerationAttribute).Name)
                {
                    // Don't sweat accuracy too much at this point.
                    return true;
                }

                return IsOrDerivesFromCodeGenerationAttribute(type.BaseType);
            }

            return false;
        }

        private static VisualStudioWorkspace GetRoslynWorkspace()
        {
            var componentModel = Package.GetGlobalService(typeof(SComponentModel)) as IComponentModel;
            Assumes.Present(componentModel);
            var workspace = componentModel.GetService<VisualStudioWorkspace>();
            return workspace;
        }

        private static Attribute Instantiate(AttributeData attributeData, Compilation compilation)
        {
            var ctor = GetConstructor(attributeData.AttributeConstructor, compilation);
            object[] args = attributeData.ConstructorArguments.Select(a => a.Value).ToArray();
            Attribute result = (Attribute)ctor.Invoke(args);

            foreach (var namedArg in attributeData.NamedArguments)
            {
                var property = ctor.DeclaringType.GetProperty(namedArg.Key);
                property.SetValue(result, namedArg.Value.Value);
            }

            return result;
        }

        private static Assembly GetAssembly(IAssemblySymbol symbol, Compilation compilation)
        {
            Requires.NotNull(symbol, "symbol");
            Requires.NotNull(compilation, "compilation");

            var matchingReferences = from reference in compilation.References.OfType<PortableExecutableReference>()
                                     where string.Equals(Path.GetFileNameWithoutExtension(reference.FilePath), symbol.Identity.Name, StringComparison.OrdinalIgnoreCase) // TODO: make this more correct
                                     select reference.FilePath;
            return Assembly.LoadFile(matchingReferences.First());
        }

        private static Type GetType(INamedTypeSymbol symbol, Compilation compilation)
        {
            Requires.NotNull(symbol, "symbol");

            var assembly = GetAssembly(symbol.ContainingAssembly, compilation);
            var nameBuilder = new StringBuilder();
            ISymbol symbolOrParent = symbol;
            while (symbolOrParent != null && !string.IsNullOrEmpty(symbolOrParent.Name))
            {
                if (nameBuilder.Length > 0)
                {
                    nameBuilder.Insert(0, ".");
                }

                nameBuilder.Insert(0, symbolOrParent.Name);
                symbolOrParent = symbolOrParent.ContainingSymbol;
            }

            Type type = assembly.GetType(nameBuilder.ToString(), true); // How to make this work more generally (nested types, etc)?
            return type;
        }

        private static ConstructorInfo GetConstructor(IMethodSymbol symbol, Compilation compilation)
        {
            Requires.NotNull(symbol, "symbol");

            Type type = GetType(symbol.ContainingType, compilation);
            return type.GetConstructors().First(ctor => ctor.GetParameters().Length == symbol.Parameters.Length); // TODO: make this pick overloads based on parameter types
        }

        private static object Construct(ConstructorInfo constructorInfo, SyntaxNode invocationSyntax, Document document)
        {
            // TODO: support parameters
            return constructorInfo.Invoke(new object[0]);
        }

        /// <summary>
        /// Gets the project and the itemid for the document with the given path.
        /// </summary>
        private static void GetSourceProjectItem(string inputFilePath, out IVsUIHierarchy hierarchy, out uint itemid)
        {
            var shellDocuments = Package.GetGlobalService(typeof(SVsUIShellOpenDocument)) as IVsUIShellOpenDocument;
            Assumes.Present(shellDocuments);
            VisualStudio.OLE.Interop.IServiceProvider sp;
            int docInProject;
            ErrorHandler.ThrowOnFailure(shellDocuments.IsDocumentInAProject(inputFilePath, out hierarchy, out itemid, out sp, out docInProject));
        }
    }
}
