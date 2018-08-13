using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using UmbracoBlogSite.Models;
using Archetype.Models;

namespace UmbracoBlogSite.Controllers
{
    public class HomeController : SurfaceController
    {
        private const string PARTIA_VIEW_FOLDER = "/Views/Partials/Home/";
        public ActionResult RenderFeatured()
        {
            List<FeaturedItem> model = new List<FeaturedItem>();
            IPublishedContent homePage = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(x => x.DocumentTypeAlias == "home").FirstOrDefault();
            ArchetypeModel featuredItems = homePage.GetPropertyValue<ArchetypeModel>("featuredItems");

            foreach (ArchetypeFieldsetModel fieldSet in featuredItems)
            {
                int imageId = fieldSet.GetValue<int>("image");
                var mediaItem = Umbraco.Media(imageId);
                string imageUrl = mediaItem.Url;

                int pageId = fieldSet.GetValue<int>("page");
                IPublishedContent linkedToPage = Umbraco.TypedContent(pageId);
                string linkUrl = linkedToPage.Url;
                model.Add(new FeaturedItem(fieldSet.GetValue<string>("name"),fieldSet.GetValue<string>("category"), imageUrl, linkUrl));
            }
            return PartialView(PARTIA_VIEW_FOLDER+"_Featured.cshtml",model);
        }

        
        public ActionResult RenderServices()
        {
            return PartialView(PARTIA_VIEW_FOLDER + "_Services.cshtml");
        }
      
        public ActionResult RenderBlog()
        {
            return PartialView(PARTIA_VIEW_FOLDER + "_Blog.cshtml");
        }
        public ActionResult RenderClients()
        {
            return PartialView(PARTIA_VIEW_FOLDER + "_Clients.cshtml");
        }
    }
}