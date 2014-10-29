﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace ImmutableObjectGraph.Tests.NonRecursive {
	using System.Diagnostics;
	using System.Linq;
	using ImmutableObjectGraph;
	
	public abstract partial class RootRecursive : IRecursiveType {
		
		/// <summary>The last identity assigned to a created instance.</summary>
		private static int lastIdentityProduced;
	
		private readonly System.Int32 identity;
	
		/// <summary>Initializes a new instance of the RootRecursive class.</summary>
		protected RootRecursive(
			System.Int32 identity,
			ImmutableObjectGraph.Optional<bool> skipValidation = default(ImmutableObjectGraph.Optional<bool>))
		{
			this.identity = identity;
		}
	
		protected internal System.Int32 Identity {
			get { return this.identity; }
		}
	
		/// <summary>Returns a unique identity that may be assigned to a newly created instance.</summary>
		protected static System.Int32 NewIdentity() {
			return System.Threading.Interlocked.Increment(ref lastIdentityProduced);
		}
		
		public virtual ContainerOfNonRecursiveCollection ToContainerOfNonRecursiveCollection(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>> metadata = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>>)) {
			ContainerOfNonRecursiveCollection that = this as ContainerOfNonRecursiveCollection;
			if (that != null && this.GetType().IsEquivalentTo(typeof(ContainerOfNonRecursiveCollection))) {
				if ((!metadata.IsDefined || metadata.Value == that.Metadata)) {
					return that;
				}
			}
		
			return ContainerOfNonRecursiveCollection.CreateWithIdentity(
				identity: this.Identity,
				metadata: metadata);
		}
		
		public virtual NonRecursiveElement ToNonRecursiveElement(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> value = default(ImmutableObjectGraph.Optional<System.String>)) {
			NonRecursiveElement that = this as NonRecursiveElement;
			if (that != null && this.GetType().IsEquivalentTo(typeof(NonRecursiveElement))) {
				if ((!name.IsDefined || name.Value == that.Name) && 
				    (!value.IsDefined || value.Value == that.Value)) {
					return that;
				}
			}
		
			return NonRecursiveElement.CreateWithIdentity(
				identity: this.Identity,
				name: name,
				value: value);
		}
	
		int IRecursiveType.Identity {
			get { return this.Identity; }
		}
	}
	
	public abstract partial class RecursiveContainer : RootRecursive, System.Collections.Generic.IEnumerable<RootRecursive>, IRecursiveParentWithOrderedChildren, IRecursiveParent<RootRecursive>, IRecursiveParentWithFastLookup {
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<RootRecursive> children;
	
		/// <summary>Initializes a new instance of the RecursiveContainer class.</summary>
		protected RecursiveContainer(
			System.Int32 identity,
			System.Collections.Immutable.ImmutableList<RootRecursive> children,
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>>> lookupTable = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>>>),
			ImmutableObjectGraph.Optional<bool> skipValidation = default(ImmutableObjectGraph.Optional<bool>))
			: base(
				identity: identity)
		{
			this.children = children;
			this.InitializeLookup(lookupTable);
		}
	
		public System.Collections.Immutable.ImmutableList<RootRecursive> Children {
			get { return this.children; }
		}
		
		/// <summary>Replaces the elements of the Children collection with the specified collection.</summary>
		public RecursiveContainer WithChildren(params RootRecursive[] values) {
			return this.With(children: this.Children.ResetContents(values));
		}
		
		/// <summary>Replaces the elements of the Children collection with the specified collection.</summary>
		public RecursiveContainer WithChildren(System.Collections.Generic.IEnumerable<RootRecursive> values) {
			return this.With(children: this.Children.ResetContents(values));
		}
		
		/// <summary>Adds the specified elements from the Children collection.</summary>
		public RecursiveContainer AddChildren(System.Collections.Generic.IEnumerable<RootRecursive> values) {
			return this.With(children: this.Children.AddRange(values));
		}
		
		/// <summary>Adds the specified elements from the Children collection.</summary>
		public RecursiveContainer AddChildren(params RootRecursive[] values) {
			return this.With(children: this.Children.AddRange(values));
		}
		
		/// <summary>Adds the specified element from the Children collection.</summary>
		public RecursiveContainer AddChild(RootRecursive value) {
			return this.With(children: this.Children.Add(value));
		}
		
		/// <summary>Removes the specified elements from the Children collection.</summary>
		public RecursiveContainer RemoveChildren(System.Collections.Generic.IEnumerable<RootRecursive> values) {
			return this.With(children: this.Children.RemoveRange(values.Select(v => this.SyncImmediateChildToCurrentVersion(v))));
		}
		
		/// <summary>Removes the specified elements from the Children collection.</summary>
		public RecursiveContainer RemoveChildren(params RootRecursive[] values) {
			return this.With(children: this.Children.RemoveRange(values.Select(v => this.SyncImmediateChildToCurrentVersion(v))));
		}
		
		/// <summary>Removes the specified element from the Children collection.</summary>
		public RecursiveContainer RemoveChild(RootRecursive value) {
			return this.With(children: this.Children.Remove(this.SyncImmediateChildToCurrentVersion(value)));
		}
		
		/// <summary>Clears all elements from the Children collection.</summary>
		public RecursiveContainer RemoveChildren() {
			return this.With(children: this.Children.Clear());
		}
		
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public RecursiveContainer With(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<RootRecursive>> children = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<RootRecursive>>)) {
			return (RecursiveContainer)this.WithCore(
				children: children);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		protected abstract RecursiveContainer WithCore(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<RootRecursive>> children = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<RootRecursive>>));
	
		public System.Collections.Generic.IEnumerator<RootRecursive> GetEnumerator() {
			return this.children.GetEnumerator();
		}
	
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return this.children.GetEnumerator();
		}
		
		protected RootRecursive SyncImmediateChildToCurrentVersion(RootRecursive child) {
			RootRecursive currentValue;
			if (!this.TryFindImmediateChild(child.Identity, out currentValue)) {
				throw new System.ArgumentException();
			}
		
			return currentValue;
		}
		
		public RecursiveContainer AddDescendent(RootRecursive value, RecursiveContainer parent) {
			var spine = this.GetSpine(parent);
			var newParent = parent.AddChildren(value);
			var newSpine = System.Collections.Immutable.ImmutableStack.Create(value, newParent);
			return (RecursiveContainer)this.ReplaceDescendent(spine, newSpine, spineIncludesDeletedElement: false).Peek();
		}
		
		public RecursiveContainer RemoveDescendent(RootRecursive value) {
			var spine = this.GetSpine(value);
			var spineList = spine.ToList();
			var parent = (RecursiveContainer)spineList[spineList.Count - 2];
			var newParent = parent.RemoveChildren(spineList[spineList.Count - 1]);
		
			var newSpine = System.Collections.Immutable.ImmutableStack.Create((RootRecursive)newParent);
			return (RecursiveContainer)this.ReplaceDescendent(spine, newSpine, spineIncludesDeletedElement: true).Peek();
		}
		
		public RecursiveContainer ReplaceDescendent(RootRecursive current, RootRecursive replacement) {
			var spine = this.GetSpine(current);
		
			if (spine.IsEmpty) {
				// The descendent was not found.
				throw new System.ArgumentException("Old value not found");
			}
		
			return (RecursiveContainer)this.ReplaceDescendent(spine, System.Collections.Immutable.ImmutableStack.Create(replacement), spineIncludesDeletedElement: false).Peek();
		}
		
		private System.Collections.Immutable.ImmutableStack<RootRecursive> ReplaceDescendent(System.Collections.Immutable.ImmutableStack<RootRecursive> spine, System.Collections.Immutable.ImmutableStack<RootRecursive> replacementStackTip, bool spineIncludesDeletedElement) {
			Debug.Assert(this == spine.Peek());
			var remainingSpine = spine.Pop();
			if (remainingSpine.IsEmpty || (spineIncludesDeletedElement && remainingSpine.Pop().IsEmpty)) {
				// This is the instance to be changed.
				return replacementStackTip;
			}
		
			System.Collections.Immutable.ImmutableStack<RootRecursive> newChildSpine;
			var child = remainingSpine.Peek();
			var recursiveChild = child as RecursiveContainer;
			if (recursiveChild != null) {
				newChildSpine = recursiveChild.ReplaceDescendent(remainingSpine, replacementStackTip, spineIncludesDeletedElement);
			} else {
				Debug.Assert(remainingSpine.Pop().IsEmpty); // we should be at the tail of the stack, since we're at a leaf.
				Debug.Assert(this.Children.Contains(child));
				newChildSpine = replacementStackTip;
			}
		
			var newChildren = this.Children.Replace(child, newChildSpine.Peek());
			var newSelf = this.WithChildren(newChildren);
			if (newSelf.lookupTable == lookupTableLazySentinal && this.lookupTable != null && this.lookupTable != lookupTableLazySentinal) {
				// Our newly mutated self wants a lookup table. If we already have one we can use it,
				// but it needs to be fixed up given the newly rewritten spine through our descendents.
				newSelf.lookupTable = this.FixupLookupTable(ImmutableDeque.Create(newChildSpine), ImmutableDeque.Create(remainingSpine));
				newSelf.ValidateInternalIntegrityDebugOnly();
			}
		
			return newChildSpine.Push(newSelf);
		}
		
		/// <summary>
		/// Produces a fast lookup table based on an existing one, if this node has one, to account for an updated spine among its descendents.
		/// </summary>
		/// <param name="updatedSpine">
		/// The spine of this node's new descendents' instances that are created for this change.
		/// The head is an immediate child of the new instance for this node.
		/// The tail is the node that was added or replaced.
		/// </param>
		/// <param name="oldSpine">
		/// The spine of this node's descendents that have been changed in this delta.
		/// The head is an immediate child of this instance.
		/// The tail is the node that was removed or replaced.
		/// </param>
		/// <returns>An updated lookup table.</returns>
		private System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>> FixupLookupTable(ImmutableObjectGraph.ImmutableDeque<RootRecursive> updatedSpine, ImmutableObjectGraph.ImmutableDeque<RootRecursive> oldSpine) {
			if (this.lookupTable == null || this.lookupTable == lookupTableLazySentinal) {
				// We don't already have a lookup table to base this on, so leave it to the new instance to lazily construct.
				return lookupTableLazySentinal;
			}
		
			if ((updatedSpine.IsEmpty && oldSpine.IsEmpty) ||
				(updatedSpine.Count > 1 && oldSpine.Count > 1 && System.Object.ReferenceEquals(updatedSpine.PeekHead(), oldSpine.PeekHead()))) {
				// No changes were actually made.
				return this.lookupTable;
			}
		
			var lookupTable = this.lookupTable.ToBuilder();
		
			// Classify the kind of change that has just occurred.
			var oldSpineTail = oldSpine.PeekTail();
			var newSpineTail = updatedSpine.PeekTail();
			ChangeKind changeKind;
			bool childrenChanged = false;
			if (updatedSpine.Count == oldSpine.Count) {
				changeKind = ChangeKind.Replaced;
				var oldSpineTailRecursive = oldSpineTail as RecursiveContainer;
				var newSpineTailRecursive = newSpineTail as RecursiveContainer;
				if (oldSpineTailRecursive != null || newSpineTailRecursive != null) {
					// Children have changed if either before or after type didn't have a children property,
					// or if both did, but the children actually changed.
					childrenChanged = oldSpineTailRecursive == null || newSpineTailRecursive == null
						|| !System.Object.ReferenceEquals(oldSpineTailRecursive.Children, newSpineTailRecursive.Children);
				}
			} else if (updatedSpine.Count > oldSpine.Count) {
				changeKind = ChangeKind.Added;
			} else // updatedSpine.Count < oldSpine.Count
			{
				changeKind = ChangeKind.Removed;
			}
		
			// Trim the lookup table of any entries for nodes that have been removed from the tree.
			if (childrenChanged || changeKind == ChangeKind.Removed) {
				// We need to remove all descendents of the old tail node.
				lookupTable.RemoveRange(oldSpineTail.GetSelfAndDescendents().Select(n => n.Identity));
			} else if (changeKind == ChangeKind.Replaced && oldSpineTail.Identity != newSpineTail.Identity) {
				// The identity of the node was changed during the replacement.  We must explicitly remove the old entry
				// from our lookup table in this case.
				lookupTable.Remove(oldSpineTail.Identity);
		
				// We also need to update any immediate children of the old spine tail
				// because the identity of their parent has changed.
				var oldSpineTailRecursive = oldSpineTail as RecursiveContainer;
				if (oldSpineTailRecursive != null) {
					foreach (var child in oldSpineTailRecursive) {
						lookupTable[child.Identity] = new System.Collections.Generic.KeyValuePair<RootRecursive, int>(child, newSpineTail.Identity);
					}
				}
			}
		
			// Update our lookup table so that it includes (updated) entries for every member of the spine itself.
			RootRecursive parent = this;
			foreach (var node in updatedSpine) {
				// Remove and add rather than use the Set method, since the old and new node are equal (in identity) therefore the map class will
				// assume no change is relevant and not apply the change.
				lookupTable.Remove(node.Identity);
				lookupTable.Add(node.Identity, new System.Collections.Generic.KeyValuePair<RootRecursive, int>(node, parent.Identity));
				parent = node;
			}
		
			// There may be children on the added node that we should include.
			if (childrenChanged || changeKind == ChangeKind.Added) {
				var recursiveParent = parent as RecursiveContainer;
				if (recursiveParent != null) {
					recursiveParent.ContributeDescendentsToLookupTable(lookupTable);
				}
			}
		
			return lookupTable.ToImmutable();
		}
		
		/// <summary>
		/// Validates this node and all its descendents <em>only in DEBUG builds</em>.
		/// </summary>
		[Conditional("DEBUG")]
		private void ValidateInternalIntegrityDebugOnly() {
			this.ValidateInternalIntegrity();
		}
		
		/// <summary>
		/// Validates this node and all its descendents.
		/// </summary>
		protected internal void ValidateInternalIntegrity() {
			// Each node id appears at most once.
			var observedIdentities = new System.Collections.Generic.HashSet<int>();
			foreach (var node in this.GetSelfAndDescendents()) {
				if (!observedIdentities.Add(node.Identity)) {
					throw new RecursiveChildNotUniqueException(node.Identity);
				}
			}
		
			// The lookup table (if any) accurately describes the contents of this tree.
			if (this.lookupTable != null && this.lookupTable != lookupTableLazySentinal) {
				// The table should have one entry for every *descendent* of this node (not this node itself).
				int expectedCount = this.GetSelfAndDescendents().Count() - 1;
				int actualCount = this.lookupTable.Count;
				if (actualCount != expectedCount) {
					throw new System.ApplicationException(string.Format(System.Globalization.CultureInfo.CurrentCulture, "Expected {0} entries in lookup table but found {1}.", expectedCount, actualCount));
				}
		
				this.ValidateLookupTable(this.lookupTable);
			}
		}
		
		/// <summary>
		/// Validates that the contents of a lookup table are valid for all descendent nodes of this node.
		/// </summary>
		/// <param name="lookupTable">The lookup table being validated.</param>
		private void ValidateLookupTable(System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>> lookupTable) {
			const string ErrorString = "Lookup table integrity failure.";
		
			foreach (var child in this.Children) {
				var entry = lookupTable[child.Identity];
				if (!object.ReferenceEquals(entry.Key, child)) {
					throw new System.ApplicationException(ErrorString);
				}
		
				if (entry.Value != this.Identity) {
					throw new System.ApplicationException(ErrorString);
				}
		
				var recursiveChild = child as RecursiveContainer;
				if (recursiveChild != null) {
					recursiveChild.ValidateLookupTable(lookupTable);
				}
			}
		}
		
		private static readonly System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>> lookupTableLazySentinal = System.Collections.Immutable.ImmutableDictionary.Create<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>>().Add(default(System.Int32), new System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>());
		
		private System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>> lookupTable;
		
		private int inefficiencyLoad;
		
		/// <summary>
		/// The maximum number of steps allowable for a search to be done among this node's children
		/// before a faster lookup table will be built.
		/// </summary>
		internal const int InefficiencyLoadThreshold = 16;
		
		private System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>> LookupTable {
			get {
				if (this.lookupTable == lookupTableLazySentinal) {
					this.lookupTable = this.CreateLookupTable();
					this.inefficiencyLoad = 1;
				}
		
				return this.lookupTable;
			}
		}
		
		bool IRecursiveParentWithFastLookup.TryLookup(int identity, out System.Collections.Generic.KeyValuePair<IRecursiveType, int> result) {
			if (this.LookupTable != null) {
				System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32> typedResult;
				this.LookupTable.TryGetValue(identity, out typedResult);
				result = new System.Collections.Generic.KeyValuePair<IRecursiveType, int>(typedResult.Key, typedResult.Value);
				return true;
			}
		
			result = default(System.Collections.Generic.KeyValuePair<IRecursiveType, int>);
			return false;
		}
		
		private void InitializeLookup(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>>> priorLookupTable = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>>>)) {
			int inefficiencyLoad = 1; // use local until we know final value since that's faster than field access.
			if (priorLookupTable.IsDefined && priorLookupTable.Value != null) {
				this.lookupTable = priorLookupTable.Value;
			} else {
				if (this.children != null) {
					if (this.children.Count >= InefficiencyLoadThreshold) {
						// The number of children alone are enough to put us over the threshold, skip enumeration.
						inefficiencyLoad = InefficiencyLoadThreshold + 1;
					} else if (this.children.Count > 0) {
						foreach (var child in this.children) {
							var recursiveChild = child as RecursiveContainer;
							inefficiencyLoad += recursiveChild != null ? recursiveChild.inefficiencyLoad : 1;
							if (inefficiencyLoad > InefficiencyLoadThreshold) {
								break; // It's ok to under-estimate once we're above the threshold since any further would be a waste of time.
							}
						}
					}
				}
		
				if (inefficiencyLoad > InefficiencyLoadThreshold) {
					inefficiencyLoad = 1;
					this.lookupTable = lookupTableLazySentinal;
				}
			}
		
			this.inefficiencyLoad = inefficiencyLoad;
			this.ValidateInternalIntegrityDebugOnly();
		}
		
		/// <summary>
		/// Creates the lookup table that will contain all this node's children.
		/// </summary>
		/// <returns>The lookup table.</returns>
		private System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>> CreateLookupTable() {
			var table = System.Collections.Immutable.ImmutableDictionary.Create<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>>().ToBuilder();
			this.ContributeDescendentsToLookupTable(table);
			return table.ToImmutable();
		}
		
		/// <summary>
		/// Adds this node's children (recursively) to the lookup table.
		/// </summary>
		/// <param name="seedLookupTable">The lookup table to add entries to.</param>
		/// <returns>The new lookup table.</returns>
		private void ContributeDescendentsToLookupTable(System.Collections.Immutable.ImmutableDictionary<System.Int32, System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>>.Builder seedLookupTable)
		{
			foreach (var child in this.Children)
			{
				seedLookupTable.Add(child.Identity, new System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32>(child, this.Identity));
				var recursiveChild = child as RecursiveContainer;
				if (recursiveChild != null) {
					recursiveChild.ContributeDescendentsToLookupTable(seedLookupTable);
				}
			}
		}
		
		public RootRecursive Find(System.Int32 identity) {
			RootRecursive result;
			if (this.TryFind(identity, out result)) {
				return result;
			}
		
			throw new System.Collections.Generic.KeyNotFoundException();
		}
		
		/// <summary>Gets the recursive parent of the specified value, or <c>null</c> if none could be found.</summary>
		internal ParentedRecursiveType<RecursiveContainer, RootRecursive> GetParentedNode(System.Int32 identity) {
			if (this.Identity == identity) {
				return new ParentedRecursiveType<RecursiveContainer, RootRecursive>(this, null);
			}
		
			if (this.LookupTable != null) {
				System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32> lookupValue;
				if (this.LookupTable.TryGetValue(identity, out lookupValue)) {
					var parentIdentity = lookupValue.Value;
					return new ParentedRecursiveType<RecursiveContainer, RootRecursive>(this.LookupTable[identity].Key, (RecursiveContainer)this.Find(parentIdentity));
				}
			} else {
				// No lookup table means we have to aggressively search each child.
				foreach (var child in this.Children) {
					if (child.Identity.Equals(identity)) {
						return new ParentedRecursiveType<RecursiveContainer, RootRecursive>(child, this);
					}
		
					var recursiveChild = child as RecursiveContainer;
					if (recursiveChild != null) {
						var childResult = recursiveChild.GetParentedNode(identity);
						if (childResult.Value != null) {
							return childResult;
						}
					} 
				}
			}
		
			return default(ParentedRecursiveType<RecursiveContainer, RootRecursive>);
		}
		
		/// <summary>Gets the recursive parent of the specified value, or <c>null</c> if none could be found.</summary>
		internal RecursiveContainer GetParent(RootRecursive descendent) {
			return this.GetParentedNode(descendent.Identity).Parent;
		}
		
		public System.Collections.Immutable.ImmutableStack<RootRecursive> GetSpine(System.Int32 descendent) {
			var emptySpine = System.Collections.Immutable.ImmutableStack.Create<RootRecursive>();
			if (this.Identity.Equals(descendent)) {
				return emptySpine.Push(this);
			}
		
			if (this.LookupTable != null) {
				System.Collections.Generic.KeyValuePair<RootRecursive, System.Int32> lookupValue;
				if (this.LookupTable.TryGetValue(descendent, out lookupValue))
				{
					// Awesome.  We know the node the caller is looking for is a descendent of this node.
					// Now just string together all the nodes that connect this one with the sought one.
					var spine = emptySpine;
					do
					{
						spine = spine.Push(lookupValue.Key);
					}
					while (this.lookupTable.TryGetValue(lookupValue.Value, out lookupValue));
					return spine.Push(this);
				}
			} else {
				// We don't have an efficient lookup table for this node.  Aggressively search every child.
				var spine = emptySpine;
				foreach (var child in this.Children) {
					var recursiveChild = child as RecursiveContainer;
					if (recursiveChild != null) {
						spine = recursiveChild.GetSpine(descendent);
					} else if (child.Identity.Equals(descendent)) {
						spine = spine.Push(child);
					}
		
					if (!spine.IsEmpty) {
						return spine.Push(this);
					}
				}
			}
		
			// The descendent is not in this sub-tree.
			return emptySpine;
		}
		
		public System.Collections.Immutable.ImmutableStack<RootRecursive> GetSpine(RootRecursive descendent) {
			return this.GetSpine(descendent.Identity);
		}
	
		System.Collections.Generic.IEnumerable<IRecursiveType> IRecursiveParent.Children {
			get { return this.Children; }
		}
	
		System.Collections.Generic.IEnumerable<RootRecursive> IRecursiveParent<RootRecursive>.Children {
			get { return this.Children; }
		}
	
		ParentedRecursiveType<IRecursiveParent<IRecursiveType>, IRecursiveType> IRecursiveParent.GetParentedNode(int identity) {
			var parented = this.GetParentedNode(identity);
			return new ParentedRecursiveType<IRecursiveParent<IRecursiveType>, IRecursiveType>(parented.Value, parented.Parent);
		}
		int IRecursiveParentWithOrderedChildren.IndexOf(IRecursiveType value) {
			return this.Children.IndexOf((RootRecursive)value);
		}
	}
	
	public partial class ContainerOfNonRecursiveCollection : RootRecursive {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly ContainerOfNonRecursiveCollection DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<NonRecursiveElement> metadata;
	
		/// <summary>Initializes a new instance of the ContainerOfNonRecursiveCollection class.</summary>
		protected ContainerOfNonRecursiveCollection(
			System.Int32 identity,
			System.Collections.Immutable.ImmutableList<NonRecursiveElement> metadata,
			ImmutableObjectGraph.Optional<bool> skipValidation = default(ImmutableObjectGraph.Optional<bool>))
			: base(
				identity: identity)
		{
			this.metadata = metadata;
			if (!skipValidation.Value) {
				this.Validate();
			}
		}
	
		public static ContainerOfNonRecursiveCollection Create(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>> metadata = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>>)) {
			var identity = Optional.For(NewIdentity());
			return DefaultInstance.WithFactory(
				metadata: Optional.For(metadata.GetValueOrDefault(DefaultInstance.Metadata)),
				identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
	
		public System.Collections.Immutable.ImmutableList<NonRecursiveElement> Metadata {
			get { return this.metadata; }
		}
		
		/// <summary>Replaces the elements of the Metadata collection with the specified collection.</summary>
		public ContainerOfNonRecursiveCollection WithMetadata(params NonRecursiveElement[] values) {
			return this.With(metadata: this.Metadata.ResetContents(values));
		}
		
		/// <summary>Replaces the elements of the Metadata collection with the specified collection.</summary>
		public ContainerOfNonRecursiveCollection WithMetadata(System.Collections.Generic.IEnumerable<NonRecursiveElement> values) {
			return this.With(metadata: this.Metadata.ResetContents(values));
		}
		
		/// <summary>Adds the specified elements from the Metadata collection.</summary>
		public ContainerOfNonRecursiveCollection AddMetadata(System.Collections.Generic.IEnumerable<NonRecursiveElement> values) {
			return this.With(metadata: this.Metadata.AddRange(values));
		}
		
		/// <summary>Adds the specified elements from the Metadata collection.</summary>
		public ContainerOfNonRecursiveCollection AddMetadata(params NonRecursiveElement[] values) {
			return this.With(metadata: this.Metadata.AddRange(values));
		}
		
		/// <summary>Adds the specified element from the Metadata collection.</summary>
		public ContainerOfNonRecursiveCollection AddMetadata(NonRecursiveElement value) {
			return this.With(metadata: this.Metadata.Add(value));
		}
		
		/// <summary>Removes the specified elements from the Metadata collection.</summary>
		public ContainerOfNonRecursiveCollection RemoveMetadata(System.Collections.Generic.IEnumerable<NonRecursiveElement> values) {
			return this.With(metadata: this.Metadata.RemoveRange(values));
		}
		
		/// <summary>Removes the specified elements from the Metadata collection.</summary>
		public ContainerOfNonRecursiveCollection RemoveMetadata(params NonRecursiveElement[] values) {
			return this.With(metadata: this.Metadata.RemoveRange(values));
		}
		
		/// <summary>Removes the specified element from the Metadata collection.</summary>
		public ContainerOfNonRecursiveCollection RemoveMetadata(NonRecursiveElement value) {
			return this.With(metadata: this.Metadata.Remove(value));
		}
		
		/// <summary>Clears all elements from the Metadata collection.</summary>
		public ContainerOfNonRecursiveCollection RemoveMetadata() {
			return this.With(metadata: this.Metadata.Clear());
		}
		
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public ContainerOfNonRecursiveCollection With(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>> metadata = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>>)) {
			return (ContainerOfNonRecursiveCollection)this.WithCore(
				metadata: metadata);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		protected virtual ContainerOfNonRecursiveCollection WithCore(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>> metadata = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>>)) {
			var identity = default(ImmutableObjectGraph.Optional<System.Int32>);
			return this.WithFactory(
				metadata: Optional.For(metadata.GetValueOrDefault(this.Metadata)),
				identity: Optional.For(identity.GetValueOrDefault(this.Identity)));
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		private ContainerOfNonRecursiveCollection WithFactory(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>> metadata = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>>),
			ImmutableObjectGraph.Optional<System.Int32> identity = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(identity.IsDefined && identity.Value != this.Identity) || 
				(metadata.IsDefined && metadata.Value != this.Metadata)) {
				return new ContainerOfNonRecursiveCollection(
					identity: identity.GetValueOrDefault(this.Identity),
					metadata: metadata.GetValueOrDefault(this.Metadata));
			} else {
				return this;
			}
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated ContainerOfNonRecursiveCollection whose fields are initialized with default values.</summary>
		private static ContainerOfNonRecursiveCollection GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new ContainerOfNonRecursiveCollection(
				default(System.Int32),
				template.Metadata,
				skipValidation: true);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.Collections.Immutable.ImmutableList<NonRecursiveElement> Metadata { get; set; }
		}
		
		internal static ContainerOfNonRecursiveCollection CreateWithIdentity(
				ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>> metadata = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<NonRecursiveElement>>),
				ImmutableObjectGraph.Optional<System.Int32> identity = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (!identity.IsDefined) {
				identity = NewIdentity();
			}
		
			return DefaultInstance.WithFactory(
					metadata: Optional.For(metadata.GetValueOrDefault(DefaultInstance.Metadata)),
					identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
	}
	
	public partial class NonRecursiveElement : RootRecursive {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly NonRecursiveElement DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String name;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String value;
	
		/// <summary>Initializes a new instance of the NonRecursiveElement class.</summary>
		protected NonRecursiveElement(
			System.Int32 identity,
			System.String name,
			System.String value,
			ImmutableObjectGraph.Optional<bool> skipValidation = default(ImmutableObjectGraph.Optional<bool>))
			: base(
				identity: identity)
		{
			this.name = name;
			this.value = value;
			if (!skipValidation.Value) {
				this.Validate();
			}
		}
	
		public static NonRecursiveElement Create(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> value = default(ImmutableObjectGraph.Optional<System.String>)) {
			var identity = Optional.For(NewIdentity());
			return DefaultInstance.WithFactory(
				name: Optional.For(name.GetValueOrDefault(DefaultInstance.Name)),
				value: Optional.For(value.GetValueOrDefault(DefaultInstance.Value)),
				identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
	
		public System.String Name {
			get { return this.name; }
		}
	
		public System.String Value {
			get { return this.value; }
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public NonRecursiveElement With(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> value = default(ImmutableObjectGraph.Optional<System.String>)) {
			return (NonRecursiveElement)this.WithCore(
				name: name,
				value: value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		protected virtual NonRecursiveElement WithCore(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> value = default(ImmutableObjectGraph.Optional<System.String>)) {
			var identity = default(ImmutableObjectGraph.Optional<System.Int32>);
			return this.WithFactory(
				name: Optional.For(name.GetValueOrDefault(this.Name)),
				value: Optional.For(value.GetValueOrDefault(this.Value)),
				identity: Optional.For(identity.GetValueOrDefault(this.Identity)));
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		private NonRecursiveElement WithFactory(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> value = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.Int32> identity = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(identity.IsDefined && identity.Value != this.Identity) || 
				(name.IsDefined && name.Value != this.Name) || 
				(value.IsDefined && value.Value != this.Value)) {
				return new NonRecursiveElement(
					identity: identity.GetValueOrDefault(this.Identity),
					name: name.GetValueOrDefault(this.Name),
					value: value.GetValueOrDefault(this.Value));
			} else {
				return this;
			}
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated NonRecursiveElement whose fields are initialized with default values.</summary>
		private static NonRecursiveElement GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new NonRecursiveElement(
				default(System.Int32),
				template.Name,
				template.Value,
				skipValidation: true);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String Name { get; set; }
	
			internal System.String Value { get; set; }
		}
		
		internal static NonRecursiveElement CreateWithIdentity(
				ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
				ImmutableObjectGraph.Optional<System.String> value = default(ImmutableObjectGraph.Optional<System.String>),
				ImmutableObjectGraph.Optional<System.Int32> identity = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (!identity.IsDefined) {
				identity = NewIdentity();
			}
		
			return DefaultInstance.WithFactory(
					name: Optional.For(name.GetValueOrDefault(DefaultInstance.Name)),
					value: Optional.For(value.GetValueOrDefault(DefaultInstance.Value)),
					identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
	}
}


