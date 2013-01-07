﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ConsoleApplication9
{
    using System.Reflection;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class ImmutableObjectGraph : ImmutableObjectGraphBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace ");
            
            #line 14 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Namespace));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 15 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

	this.PushIndent("\t");
	var templateTypes = DiscoverTemplateTypes(this.TemplateType);
	foreach(var templateType in templateTypes) {

            
            #line default
            #line hidden
            this.Write("\r\npublic partial class ");
            
            #line 21 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateType.Name));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 22 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

	var fields = templateType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
	foreach(var field in fields) {

            
            #line default
            #line hidden
            this.Write("\r\n\tprivate readonly ");
            
            #line 27 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(field.FieldType)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 27 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CamelCase(field.Name)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 28 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

	}

            
            #line default
            #line hidden
            this.Write("\r\n\t/// <summary>Initializes a new instance of the ");
            
            #line 32 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateType.Name));
            
            #line default
            #line hidden
            this.Write(" class.</summary>\r\n\tpublic ");
            
            #line 33 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateType.Name));
            
            #line default
            #line hidden
            this.Write("()\r\n\t{\r\n\t}\r\n\r\n\t/// <summary>Initializes a new instance of the ");
            
            #line 37 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateType.Name));
            
            #line default
            #line hidden
            this.Write(" class.</summary>\r\n\tpublic ");
            
            #line 38 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateType.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 38 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

	bool firstInSequence = true;
	foreach(var field in fields) {
		if (!firstInSequence) { Write(", "); }
		Write(GetTypeName(field.FieldType));
		Write(" ");
		Write(CamelCase(field.Name));
		firstInSequence = false;
	}

            
            #line default
            #line hidden
            this.Write(")\r\n\t{\r\n");
            
            #line 49 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

	foreach(var field in fields) {

            
            #line default
            #line hidden
            this.Write("\t\tthis.");
            
            #line 52 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CamelCase(field.Name)));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 52 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CamelCase(field.Name)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 53 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

	}

            
            #line default
            #line hidden
            this.Write("\t\tthis.Validate();\r\n\t}\r\n");
            
            #line 58 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

	foreach(var field in fields) {

            
            #line default
            #line hidden
            this.Write("\r\n\tpublic ");
            
            #line 62 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(field.FieldType)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 62 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(field.Name)));
            
            #line default
            #line hidden
            this.Write(" {\r\n\t\tget { return this.");
            
            #line 63 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CamelCase(field.Name)));
            
            #line default
            #line hidden
            this.Write("; }\r\n\t}\r\n\r\n\tpublic ");
            
            #line 66 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateType.Name));
            
            #line default
            #line hidden
            this.Write(" With");
            
            #line 66 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(field.Name)));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 66 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(field.FieldType)));
            
            #line default
            #line hidden
            this.Write(" value) {\r\n\t\tif (value == this.");
            
            #line 67 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(field.Name)));
            
            #line default
            #line hidden
            this.Write(") {\r\n\t\t\treturn this;\r\n\t\t}\r\n\r\n\t\treturn new ");
            
            #line 71 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateType.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 71 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

	firstInSequence = true;
	foreach(var field2 in fields) {
		if (!firstInSequence) { Write(", "); }
		if (field == field2) {
			Write("value");
		} else {
			Write("this." + PascalCase(field2.Name));
		}

		firstInSequence = false;
	}

            
            #line default
            #line hidden
            this.Write(");\r\n\t}\r\n");
            
            #line 85 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

	}

            
            #line default
            #line hidden
            this.Write("\r\n\t/// <summary>Returns a new instance of this object with any number of properti" +
                    "es changed.</summary>\r\n\tpublic ");
            
            #line 90 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateType.Name));
            
            #line default
            #line hidden
            this.Write(" With(");
            
            #line 90 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

		firstInSequence = true;
		this.PushIndent("\t\t");

		// Value parameters
		foreach(var field in fields) {
			if (!firstInSequence) { Write(", "); }
			WriteLine("");
			Write(GetTypeName(field.FieldType));
			Write(" ");
			Write(CamelCase(field.Name));
			Write(" = default(" + GetTypeName(field.FieldType) + ")");
			firstInSequence = false;
		}

		// Reset parameters
		foreach(var field in fields) {
			WriteLine(",");
			Write("bool ");
			Write("reset" + PascalCase(field.Name));
			Write(" = false");
			firstInSequence = false;
		}

		this.PopIndent();

            
            #line default
            #line hidden
            this.Write(") {\r\n\t\treturn new ");
            
            #line 116 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateType.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 116 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

			firstInSequence = true;
			foreach(var field in fields) {
				if (!firstInSequence) { Write(","); }
				WriteLine("");

            
            #line default
            #line hidden
            this.Write("\t\t\t\treset");
            
            #line 121 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(field.Name)));
            
            #line default
            #line hidden
            this.Write(" ? default(");
            
            #line 121 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(field.FieldType)));
            
            #line default
            #line hidden
            this.Write(") : ");
            
            #line 121 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CamelCase(field.Name)));
            
            #line default
            #line hidden
            
            #line 121 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

				firstInSequence = false;
			}
	
            
            #line default
            #line hidden
            this.Write(");\r\n\t}\r\n\r\n\t/// <summary>Normalizes and/or validates all properties on this object" +
                    ".</summary>\r\n\t/// <exception type=\"ArgumentException\">Thrown if any properties h" +
                    "ave disallowed values.</exception>\r\n\tprotected partial void Validate();\r\n}\r\n");
            
            #line 131 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"
 } // looping over all template types

	this.PopIndent();

            
            #line default
            #line hidden
            this.Write("}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 136 "C:\Users\Andrew\git\ImmutableObjectGraph\ImmutableObjectGraph.tt"

	public Type TemplateType { get; set; }

	public string Namespace { get; set; }

	protected static string PascalCase(string name) {
		return name.Substring(0,1).ToUpperInvariant() + name.Substring(1);
	}

	protected static string CamelCase(string name) {
		return name.Substring(0,1).ToLowerInvariant() + name.Substring(1);
	}

	protected static HashSet<Type> DiscoverTemplateTypes(Type rootType) {
		var types = new HashSet<Type>();
		var pendingTypes = new Queue<Type>();
		pendingTypes.Enqueue(rootType);
		while(pendingTypes.Count > 0)
		{
			var type = pendingTypes.Dequeue();
			if (types.Add(type)) {
				foreach(var field in type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)) {
					var memberType = field.FieldType;
					if (memberType.IsArray) {
						memberType = memberType.GetElementType();
					}

					if (memberType.DeclaringType == type.DeclaringType) {
						pendingTypes.Enqueue(memberType);
					}
				}
			}
		}

		return types;
	}

	protected string GetTypeName(Type type) {
		bool collection = false;
		if (type.IsArray) {
			type = type.GetElementType();
			collection = true;
		}

		string typeName = 
			type.DeclaringType == this.TemplateType.DeclaringType
			? type.Name
			: type.FullName;

		if (collection) {
			typeName = "System.Collections.Immutable.ImmutableList<" + typeName + ">";
		}

		return typeName;
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class ImmutableObjectGraphBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
