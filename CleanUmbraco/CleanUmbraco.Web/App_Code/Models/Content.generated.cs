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
	/// <summary>Content</summary>
	[PublishedModel("content")]
	public partial class Content : PublishedContentModel, IContentControls, IHeaderControls, IMainImageControls, ISEocontrols, IVisibilityControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public new const string ModelTypeAlias = "content";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Content, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Content(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Main Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("mainContent")]
		public global::Newtonsoft.Json.Linq.JToken MainContent => global::Umbraco.Web.PublishedModels.ContentControls.GetMainContent(this);

		///<summary>
		/// Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("subtitle")]
		public string Subtitle => global::Umbraco.Web.PublishedModels.HeaderControls.GetSubtitle(this);

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("title")]
		public string Title => global::Umbraco.Web.PublishedModels.HeaderControls.GetTitle(this);

		///<summary>
		/// Main Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("mainImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent MainImage => global::Umbraco.Web.PublishedModels.MainImageControls.GetMainImage(this);

		///<summary>
		/// Meta Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaDescription(this);

		///<summary>
		/// Meta Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("metaKeywords")]
		public global::System.Collections.Generic.IEnumerable<string> MetaKeywords => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaKeywords(this);

		///<summary>
		/// Meta Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("metaName")]
		public string MetaName => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaName(this);

		///<summary>
		/// Hide from XML Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("hideFromXMLSitemap")]
		public bool HideFromXmlsitemap => global::Umbraco.Web.PublishedModels.VisibilityControls.GetHideFromXmlsitemap(this);

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => global::Umbraco.Web.PublishedModels.VisibilityControls.GetUmbracoNaviHide(this);
	}
}
