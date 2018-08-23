//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
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
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "5dfc14bbe240175f")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.5")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IFeaturedItemControls, IIntroControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Featured Items: Enter featured items
		///</summary>
		[ImplementPropertyType("featuredItems")]
		public Archetype.Models.ArchetypeModel FeaturedItems
		{
			get { return Umbraco.Web.PublishedContentModels.FeaturedItemControls.GetFeaturedItems(this); }
		}

		///<summary>
		/// Visible: Disable if you want to hide the component
		///</summary>
		[ImplementPropertyType("visible")]
		public bool Visible
		{
			get { return Umbraco.Web.PublishedContentModels.FeaturedItemControls.GetVisible(this); }
		}

		///<summary>
		/// Intro: Enter your introduction
		///</summary>
		[ImplementPropertyType("intro")]
		public string Intro
		{
			get { return Umbraco.Web.PublishedContentModels.IntroControls.GetIntro(this); }
		}
	}

	/// <summary>Blog</summary>
	[PublishedContentModel("blog")]
	public partial class Blog : PublishedContentModel, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blog";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Blog(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Blog, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Title: Enter the sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title here. If left blank the page name will be used.
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetTitle(this); }
		}
	}

	/// <summary>Services</summary>
	[PublishedContentModel("services")]
	public partial class Services : PublishedContentModel, ITitleControls, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "services";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Services(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Services, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Title: Enter the sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title here. If left blank the page name will be used.
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetTitle(this); }
		}

		///<summary>
		/// Exclude From Top Navigation
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return Umbraco.Web.PublishedContentModels.TopNavigationControls.GetExcludeFromTopNavigation(this); }
		}
	}

	/// <summary>Portofolio</summary>
	[PublishedContentModel("portofolio")]
	public partial class Portofolio : PublishedContentModel, ITitleControls, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "portofolio";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Portofolio(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Portofolio, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Title: Enter the sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title here. If left blank the page name will be used.
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetTitle(this); }
		}

		///<summary>
		/// Exclude From Top Navigation
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return Umbraco.Web.PublishedContentModels.TopNavigationControls.GetExcludeFromTopNavigation(this); }
		}
	}

	/// <summary>About</summary>
	[PublishedContentModel("about")]
	public partial class About : PublishedContentModel, IBasicContentControls, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "about";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public About(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<About, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content grid: Enter the content for the page
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// Sub Title: Enter the sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title here. If left blank the page name will be used.
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetTitle(this); }
		}
	}

	/// <summary>Contact</summary>
	[PublishedContentModel("contact")]
	public partial class Contact : PublishedContentModel, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contact";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Contact(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Contact, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Title: Enter the sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title here. If left blank the page name will be used.
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetTitle(this); }
		}
	}

	// Mixin content Type 1081 with alias "introControls"
	/// <summary>Intro Controls</summary>
	public partial interface IIntroControls : IPublishedContent
	{
		/// <summary>Intro</summary>
		string Intro { get; }
	}

	/// <summary>Intro Controls</summary>
	[PublishedContentModel("introControls")]
	public partial class IntroControls : PublishedContentModel, IIntroControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "introControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public IntroControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<IntroControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Intro: Enter your introduction
		///</summary>
		[ImplementPropertyType("intro")]
		public string Intro
		{
			get { return GetIntro(this); }
		}

		/// <summary>Static getter for Intro</summary>
		public static string GetIntro(IIntroControls that) { return that.GetPropertyValue<string>("intro"); }
	}

	// Mixin content Type 1082 with alias "titleControls"
	/// <summary>Title Controls</summary>
	public partial interface ITitleControls : IPublishedContent
	{
		/// <summary>Sub Title</summary>
		IHtmlString SubTitle { get; }

		/// <summary>Title</summary>
		string Title { get; }
	}

	/// <summary>Title Controls</summary>
	[PublishedContentModel("titleControls")]
	public partial class TitleControls : PublishedContentModel, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "titleControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TitleControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TitleControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Title: Enter the sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return GetSubTitle(this); }
		}

		/// <summary>Static getter for Sub Title</summary>
		public static IHtmlString GetSubTitle(ITitleControls that) { return that.GetPropertyValue<IHtmlString>("subTitle"); }

		///<summary>
		/// Title: Enter the title here. If left blank the page name will be used.
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return GetTitle(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetTitle(ITitleControls that) { return that.GetPropertyValue<string>("title"); }
	}

	// Mixin content Type 1085 with alias "basicContentControls"
	/// <summary>Basic content controls</summary>
	public partial interface IBasicContentControls : IPublishedContent
	{
		/// <summary>Content grid</summary>
		Newtonsoft.Json.Linq.JToken ContentGrid { get; }
	}

	/// <summary>Basic content controls</summary>
	[PublishedContentModel("basicContentControls")]
	public partial class BasicContentControls : PublishedContentModel, IBasicContentControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basicContentControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasicContentControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicContentControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content grid: Enter the content for the page
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return GetContentGrid(this); }
		}

		/// <summary>Static getter for Content grid</summary>
		public static Newtonsoft.Json.Linq.JToken GetContentGrid(IBasicContentControls that) { return that.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("contentGrid"); }
	}

	// Mixin content Type 1088 with alias "topNavigationControls"
	/// <summary>Top Navigation Controls</summary>
	public partial interface ITopNavigationControls : IPublishedContent
	{
		/// <summary>Exclude From Top Navigation</summary>
		bool ExcludeFromTopNavigation { get; }
	}

	/// <summary>Top Navigation Controls</summary>
	[PublishedContentModel("topNavigationControls")]
	public partial class TopNavigationControls : PublishedContentModel, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "topNavigationControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TopNavigationControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TopNavigationControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Exclude From Top Navigation
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return GetExcludeFromTopNavigation(this); }
		}

		/// <summary>Static getter for Exclude From Top Navigation</summary>
		public static bool GetExcludeFromTopNavigation(ITopNavigationControls that) { return that.GetPropertyValue<bool>("excludeFromTopNavigation"); }
	}

	// Mixin content Type 1090 with alias "featuredItemControls"
	/// <summary>Featured Item Controls</summary>
	public partial interface IFeaturedItemControls : IPublishedContent
	{
		/// <summary>Featured Items</summary>
		Archetype.Models.ArchetypeModel FeaturedItems { get; }

		/// <summary>Visible</summary>
		bool Visible { get; }
	}

	/// <summary>Featured Item Controls</summary>
	[PublishedContentModel("featuredItemControls")]
	public partial class FeaturedItemControls : PublishedContentModel, IFeaturedItemControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "featuredItemControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public FeaturedItemControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FeaturedItemControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Featured Items: Enter featured items
		///</summary>
		[ImplementPropertyType("featuredItems")]
		public Archetype.Models.ArchetypeModel FeaturedItems
		{
			get { return GetFeaturedItems(this); }
		}

		/// <summary>Static getter for Featured Items</summary>
		public static Archetype.Models.ArchetypeModel GetFeaturedItems(IFeaturedItemControls that) { return that.GetPropertyValue<Archetype.Models.ArchetypeModel>("featuredItems"); }

		///<summary>
		/// Visible: Disable if you want to hide the component
		///</summary>
		[ImplementPropertyType("visible")]
		public bool Visible
		{
			get { return GetVisible(this); }
		}

		/// <summary>Static getter for Visible</summary>
		public static bool GetVisible(IFeaturedItemControls that) { return that.GetPropertyValue<bool>("visible"); }
	}

	// Mixin content Type 1096 with alias "articleControls"
	/// <summary>Article Controls</summary>
	public partial interface IArticleControls : IPublishedContent
	{
		/// <summary>Article Image</summary>
		IPublishedContent ArticleImage { get; }

		/// <summary>Article Introduction</summary>
		string ArticleIntroduction { get; }
	}

	/// <summary>Article Controls</summary>
	[PublishedContentModel("articleControls")]
	public partial class ArticleControls : PublishedContentModel, IArticleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "articleControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticleControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticleControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Article Image: Choose article image
		///</summary>
		[ImplementPropertyType("articleImage")]
		public IPublishedContent ArticleImage
		{
			get { return GetArticleImage(this); }
		}

		/// <summary>Static getter for Article Image</summary>
		public static IPublishedContent GetArticleImage(IArticleControls that) { return that.GetPropertyValue<IPublishedContent>("articleImage"); }

		///<summary>
		/// Article Introduction: Enter article introduction here
		///</summary>
		[ImplementPropertyType("articleIntroduction")]
		public string ArticleIntroduction
		{
			get { return GetArticleIntroduction(this); }
		}

		/// <summary>Static getter for Article Introduction</summary>
		public static string GetArticleIntroduction(IArticleControls that) { return that.GetPropertyValue<string>("articleIntroduction"); }
	}

	/// <summary>Blog Post</summary>
	[PublishedContentModel("blogPost")]
	public partial class BlogPost : PublishedContentModel, IArticleControls, IBasicContentControls, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Article Image: Choose article image
		///</summary>
		[ImplementPropertyType("articleImage")]
		public IPublishedContent ArticleImage
		{
			get { return Umbraco.Web.PublishedContentModels.ArticleControls.GetArticleImage(this); }
		}

		///<summary>
		/// Article Introduction: Enter article introduction here
		///</summary>
		[ImplementPropertyType("articleIntroduction")]
		public string ArticleIntroduction
		{
			get { return Umbraco.Web.PublishedContentModels.ArticleControls.GetArticleIntroduction(this); }
		}

		///<summary>
		/// Content grid: Enter the content for the page
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// Sub Title: Enter the sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title here. If left blank the page name will be used.
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetTitle(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
