//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.3
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "headerControls"
	/// <summary>Header Controls</summary>
	public partial interface IHeaderControls : IPublishedContent
	{
		/// <summary>Subtitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		string Subtitle { get; }

		/// <summary>Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		string Title { get; }
	}

	/// <summary>Header Controls</summary>
	[PublishedModel("headerControls")]
	public partial class HeaderControls : PublishedContentModel, IHeaderControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public new const string ModelTypeAlias = "headerControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HeaderControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HeaderControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("subtitle")]
		public string Subtitle => GetSubtitle(this);

		/// <summary>Static getter for Subtitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public static string GetSubtitle(IHeaderControls that) => that.Value<string>("subtitle");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("title")]
		public string Title => GetTitle(this);

		/// <summary>Static getter for Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public static string GetTitle(IHeaderControls that) => that.Value<string>("title");
	}
}
