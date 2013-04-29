﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Demo {
	using System.Diagnostics;
	using ImmutableObjectGraph;

	
	public interface IMessage {
		Contact Author { get; }
		System.Collections.Immutable.ImmutableList<Contact> To { get; }
		System.Collections.Immutable.ImmutableList<Contact> Cc { get; }
		System.Collections.Immutable.ImmutableList<Contact> Bcc { get; }
		System.String Subject { get; }
		System.String Body { get; }
	}
	
	public partial class Message : IMessage {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Message DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Contact author;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<Contact> to;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<Contact> cc;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<Contact> bcc;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String subject;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String body;
	
		/// <summary>Initializes a new instance of the Message class.</summary>
		protected Message()
		{
		}
	
		/// <summary>Initializes a new instance of the Message class.</summary>
		protected Message(
			Contact author,
			System.Collections.Immutable.ImmutableList<Contact> to,
			System.Collections.Immutable.ImmutableList<Contact> cc,
			System.Collections.Immutable.ImmutableList<Contact> bcc,
			System.String subject,
			System.String body)
			: base()
		{
			this.author = author;
			this.to = to;
			this.cc = cc;
			this.bcc = bcc;
			this.subject = subject;
			this.body = body;
			this.Validate();
		}
	
		public static Message Create(
			ImmutableObjectGraph.Optional<Contact> author = default(ImmutableObjectGraph.Optional<Contact>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> to = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> cc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> bcc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.String> subject = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> body = default(ImmutableObjectGraph.Optional<System.String>)) {
			return DefaultInstance.With(
				author.GetValueOrDefault(DefaultInstance.Author), 
				to.GetValueOrDefault(DefaultInstance.To), 
				cc.GetValueOrDefault(DefaultInstance.Cc), 
				bcc.GetValueOrDefault(DefaultInstance.Bcc), 
				subject.GetValueOrDefault(DefaultInstance.Subject), 
				body.GetValueOrDefault(DefaultInstance.Body));
		}
	
		public Contact Author {
			get { return this.author; }
		}
	
		public System.Collections.Immutable.ImmutableList<Contact> To {
			get { return this.to; }
		}
	
		public System.Collections.Immutable.ImmutableList<Contact> Cc {
			get { return this.cc; }
		}
	
		public System.Collections.Immutable.ImmutableList<Contact> Bcc {
			get { return this.bcc; }
		}
	
		public System.String Subject {
			get { return this.subject; }
		}
	
		public System.String Body {
			get { return this.body; }
		}
		/// <summary>Returns a new instance with the Author property set to the specified value.</summary>
		public Message WithAuthor(Contact value) {
			if (value == this.Author) {
				return this;
			}
	
			return this.With(author: value);
		}
		/// <summary>Returns a new instance with the To property set to the specified value.</summary>
		public Message WithTo(System.Collections.Immutable.ImmutableList<Contact> value) {
			if (value == this.To) {
				return this;
			}
	
			return this.With(to: value);
		}
	
		/// <summary>Replaces the elements of the To collection with the specified collection.</summary>
		public Message WithTo(params Contact[] values) {
			return this.With(to: this.To.ResetContents(values));
		}
	
		/// <summary>Replaces the elements of the To collection with the specified collection.</summary>
		public Message WithTo(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(to: this.To.ResetContents(values));
		}
	
		/// <summary>Adds the specified elements from the To collection.</summary>
		public Message AddTo(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(to: this.To.AddRange(values));
		}
	
		/// <summary>Adds the specified elements from the To collection.</summary>
		public Message AddTo(params Contact[] values) {
			return this.With(to: this.To.AddRange(values));
		}
	
		/// <summary>Adds the specified element from the To collection.</summary>
		public Message AddTo(Contact value) {
			return this.With(to: this.To.Add(value));
		}
	
		/// <summary>Removes the specified elements from the To collection.</summary>
		public Message RemoveTo(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(to: this.To.RemoveRange(values));
		}
	
		/// <summary>Removes the specified elements from the To collection.</summary>
		public Message RemoveTo(params Contact[] values) {
			return this.With(to: this.To.RemoveRange(values));
		}
	
		/// <summary>Removes the specified element from the To collection.</summary>
		public Message RemoveTo(Contact value) {
			return this.With(to: this.To.Remove(value));
		}
	
		/// <summary>Clears all elements from the To collection.</summary>
		public Message RemoveTo() {
			return this.With(to: this.To.Clear());
		}
		/// <summary>Returns a new instance with the Cc property set to the specified value.</summary>
		public Message WithCc(System.Collections.Immutable.ImmutableList<Contact> value) {
			if (value == this.Cc) {
				return this;
			}
	
			return this.With(cc: value);
		}
	
		/// <summary>Replaces the elements of the Cc collection with the specified collection.</summary>
		public Message WithCc(params Contact[] values) {
			return this.With(cc: this.Cc.ResetContents(values));
		}
	
		/// <summary>Replaces the elements of the Cc collection with the specified collection.</summary>
		public Message WithCc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(cc: this.Cc.ResetContents(values));
		}
	
		/// <summary>Adds the specified elements from the Cc collection.</summary>
		public Message AddCc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(cc: this.Cc.AddRange(values));
		}
	
		/// <summary>Adds the specified elements from the Cc collection.</summary>
		public Message AddCc(params Contact[] values) {
			return this.With(cc: this.Cc.AddRange(values));
		}
	
		/// <summary>Adds the specified element from the Cc collection.</summary>
		public Message AddCc(Contact value) {
			return this.With(cc: this.Cc.Add(value));
		}
	
		/// <summary>Removes the specified elements from the Cc collection.</summary>
		public Message RemoveCc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(cc: this.Cc.RemoveRange(values));
		}
	
		/// <summary>Removes the specified elements from the Cc collection.</summary>
		public Message RemoveCc(params Contact[] values) {
			return this.With(cc: this.Cc.RemoveRange(values));
		}
	
		/// <summary>Removes the specified element from the Cc collection.</summary>
		public Message RemoveCc(Contact value) {
			return this.With(cc: this.Cc.Remove(value));
		}
	
		/// <summary>Clears all elements from the Cc collection.</summary>
		public Message RemoveCc() {
			return this.With(cc: this.Cc.Clear());
		}
		/// <summary>Returns a new instance with the Bcc property set to the specified value.</summary>
		public Message WithBcc(System.Collections.Immutable.ImmutableList<Contact> value) {
			if (value == this.Bcc) {
				return this;
			}
	
			return this.With(bcc: value);
		}
	
		/// <summary>Replaces the elements of the Bcc collection with the specified collection.</summary>
		public Message WithBcc(params Contact[] values) {
			return this.With(bcc: this.Bcc.ResetContents(values));
		}
	
		/// <summary>Replaces the elements of the Bcc collection with the specified collection.</summary>
		public Message WithBcc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(bcc: this.Bcc.ResetContents(values));
		}
	
		/// <summary>Adds the specified elements from the Bcc collection.</summary>
		public Message AddBcc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(bcc: this.Bcc.AddRange(values));
		}
	
		/// <summary>Adds the specified elements from the Bcc collection.</summary>
		public Message AddBcc(params Contact[] values) {
			return this.With(bcc: this.Bcc.AddRange(values));
		}
	
		/// <summary>Adds the specified element from the Bcc collection.</summary>
		public Message AddBcc(Contact value) {
			return this.With(bcc: this.Bcc.Add(value));
		}
	
		/// <summary>Removes the specified elements from the Bcc collection.</summary>
		public Message RemoveBcc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(bcc: this.Bcc.RemoveRange(values));
		}
	
		/// <summary>Removes the specified elements from the Bcc collection.</summary>
		public Message RemoveBcc(params Contact[] values) {
			return this.With(bcc: this.Bcc.RemoveRange(values));
		}
	
		/// <summary>Removes the specified element from the Bcc collection.</summary>
		public Message RemoveBcc(Contact value) {
			return this.With(bcc: this.Bcc.Remove(value));
		}
	
		/// <summary>Clears all elements from the Bcc collection.</summary>
		public Message RemoveBcc() {
			return this.With(bcc: this.Bcc.Clear());
		}
		/// <summary>Returns a new instance with the Subject property set to the specified value.</summary>
		public Message WithSubject(System.String value) {
			if (value == this.Subject) {
				return this;
			}
	
			return this.With(subject: value);
		}
		/// <summary>Returns a new instance with the Body property set to the specified value.</summary>
		public Message WithBody(System.String value) {
			if (value == this.Body) {
				return this;
			}
	
			return this.With(body: value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual Message With(
			ImmutableObjectGraph.Optional<Contact> author = default(ImmutableObjectGraph.Optional<Contact>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> to = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> cc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> bcc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.String> subject = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> body = default(ImmutableObjectGraph.Optional<System.String>)) {
			if (
				(author.IsDefined && author.Value != this.Author) || 
				(to.IsDefined && to.Value != this.To) || 
				(cc.IsDefined && cc.Value != this.Cc) || 
				(bcc.IsDefined && bcc.Value != this.Bcc) || 
				(subject.IsDefined && subject.Value != this.Subject) || 
				(body.IsDefined && body.Value != this.Body)) {
				return new Message(
					author.GetValueOrDefault(this.Author),
					to.GetValueOrDefault(this.To),
					cc.GetValueOrDefault(this.Cc),
					bcc.GetValueOrDefault(this.Bcc),
					subject.GetValueOrDefault(this.Subject),
					body.GetValueOrDefault(this.Body));
			} else {
				return this;
			}
		}
	
	
		public Builder ToBuilder() {
			return new Builder(this);
		}
	
	
	 
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated Message whose fields are initialized with default values.</summary>
		private static Message GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new Message(
				template.Author, 
				template.To, 
				template.Cc, 
				template.Bcc, 
				template.Subject, 
				template.Body);
		}
	
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Message immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<Contact.Builder> author;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>.Builder> to;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>.Builder> cc;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>.Builder> bcc;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String subject;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String body;
	
			internal Builder(Message immutable) {
				this.immutable = immutable;
	
				this.subject = immutable.Subject;
				this.body = immutable.Body;
			}
	
			public Contact.Builder Author {
				get {
					if (!this.author.IsDefined) {
						this.author = this.immutable.author != null ? this.immutable.author.ToBuilder() : null;
					}
	
					return this.author.Value;
				}
	
				set {
					this.author = value;
				}
			}
	
			public System.Collections.Immutable.ImmutableList<Contact>.Builder To {
				get {
					if (!this.to.IsDefined) {
						this.to = this.immutable.to != null ? this.immutable.to.ToBuilder() : null;
					}
	
					return this.to.Value;
				}
	
				set {
					this.to = value;
				}
			}
	
			public System.Collections.Immutable.ImmutableList<Contact>.Builder Cc {
				get {
					if (!this.cc.IsDefined) {
						this.cc = this.immutable.cc != null ? this.immutable.cc.ToBuilder() : null;
					}
	
					return this.cc.Value;
				}
	
				set {
					this.cc = value;
				}
			}
	
			public System.Collections.Immutable.ImmutableList<Contact>.Builder Bcc {
				get {
					if (!this.bcc.IsDefined) {
						this.bcc = this.immutable.bcc != null ? this.immutable.bcc.ToBuilder() : null;
					}
	
					return this.bcc.Value;
				}
	
				set {
					this.bcc = value;
				}
			}
	
			public System.String Subject {
				get {
					return this.subject;
				}
	
				set {
					this.subject = value;
				}
			}
	
			public System.String Body {
				get {
					return this.body;
				}
	
				set {
					this.body = value;
				}
			}
	
			public Message ToImmutable() {
				var author = this.author.IsDefined ? (this.author.Value != null ? this.author.Value.ToImmutable() : null) : this.immutable.Author;
				var to = this.to.IsDefined ? (this.to.Value != null ? this.to.Value.ToImmutable() : null) : this.immutable.To;
				var cc = this.cc.IsDefined ? (this.cc.Value != null ? this.cc.Value.ToImmutable() : null) : this.immutable.Cc;
				var bcc = this.bcc.IsDefined ? (this.bcc.Value != null ? this.bcc.Value.ToImmutable() : null) : this.immutable.Bcc;
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(author),
					ImmutableObjectGraph.Optional.For(to),
					ImmutableObjectGraph.Optional.For(cc),
					ImmutableObjectGraph.Optional.For(bcc),
					ImmutableObjectGraph.Optional.For(this.Subject),
					ImmutableObjectGraph.Optional.For(this.Body));
			}
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal Contact Author { get; set; }
	
			internal System.Collections.Immutable.ImmutableList<Contact> To { get; set; }
	
			internal System.Collections.Immutable.ImmutableList<Contact> Cc { get; set; }
	
			internal System.Collections.Immutable.ImmutableList<Contact> Bcc { get; set; }
	
			internal System.String Subject { get; set; }
	
			internal System.String Body { get; set; }
		}
	}
	
	public interface IContact {
		System.String Name { get; }
		System.String Email { get; }
	}
	
	public partial class Contact : IContact {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Contact DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String name;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String email;
	
		/// <summary>Initializes a new instance of the Contact class.</summary>
		protected Contact()
		{
		}
	
		/// <summary>Initializes a new instance of the Contact class.</summary>
		protected Contact(
			System.String name,
			System.String email)
			: base()
		{
			this.name = name;
			this.email = email;
			this.Validate();
		}
	
		public static Contact Create(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> email = default(ImmutableObjectGraph.Optional<System.String>)) {
			return DefaultInstance.With(
				name.GetValueOrDefault(DefaultInstance.Name), 
				email.GetValueOrDefault(DefaultInstance.Email));
		}
	
		public System.String Name {
			get { return this.name; }
		}
	
		public System.String Email {
			get { return this.email; }
		}
		/// <summary>Returns a new instance with the Name property set to the specified value.</summary>
		public Contact WithName(System.String value) {
			if (value == this.Name) {
				return this;
			}
	
			return this.With(name: value);
		}
		/// <summary>Returns a new instance with the Email property set to the specified value.</summary>
		public Contact WithEmail(System.String value) {
			if (value == this.Email) {
				return this;
			}
	
			return this.With(email: value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual Contact With(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> email = default(ImmutableObjectGraph.Optional<System.String>)) {
			if (
				(name.IsDefined && name.Value != this.Name) || 
				(email.IsDefined && email.Value != this.Email)) {
				return new Contact(
					name.GetValueOrDefault(this.Name),
					email.GetValueOrDefault(this.Email));
			} else {
				return this;
			}
		}
	
	
		public Builder ToBuilder() {
			return new Builder(this);
		}
	
	
	 
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated Contact whose fields are initialized with default values.</summary>
		private static Contact GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new Contact(
				template.Name, 
				template.Email);
		}
	
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Contact immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String name;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String email;
	
			internal Builder(Contact immutable) {
				this.immutable = immutable;
	
				this.name = immutable.Name;
				this.email = immutable.Email;
			}
	
			public System.String Name {
				get {
					return this.name;
				}
	
				set {
					this.name = value;
				}
			}
	
			public System.String Email {
				get {
					return this.email;
				}
	
				set {
					this.email = value;
				}
			}
	
			public Contact ToImmutable() {
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.Name),
					ImmutableObjectGraph.Optional.For(this.Email));
			}
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String Name { get; set; }
	
			internal System.String Email { get; set; }
		}
	}
}
