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
        private const string PARTIAL_VIEW_FOLDER = "/Views/Partials/Home/";
        public ActionResult RenderFeatured()
        {
            List<FeaturedItem> model = new List<FeaturedItem>();
            IPublishedContent homePage = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(x => x.DocumentTypeAlias == "home").FirstOrDefault();
            ArchetypeModel featuredItems = homePage.GetPropertyValue<ArchetypeModel>("featuredItems");
            bool featuredItemsVisible = (bool)homePage.GetPropertyValue("visible");

            if(featuredItemsVisible)
            {
                foreach (ArchetypeFieldsetModel fieldSet in featuredItems)
                {

                    var mediaItem = fieldSet.GetValue<IPublishedContent>("image");
                    string imageUrl = mediaItem.Url;

                    var pageId = fieldSet.GetValue<IPublishedContent>("page");
                    IPublishedContent linkedToPage = Umbraco.TypedContent(pageId.Id);
                    string linkUrl = linkedToPage.Url;
                    model.Add(new FeaturedItem(fieldSet.GetValue<string>("name"), fieldSet.GetValue<string>("category"), imageUrl, linkUrl));
                }
                return PartialView(PARTIAL_VIEW_FOLDER + "_Featured.cshtml", model);
            }
            else
                return null;
        }

        
        public ActionResult RenderServices()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Services.cshtml");
        }
      
        public ActionResult RenderBlog()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Blog.cshtml");
        }
        public ActionResult RenderClients()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Clients.cshtml");
        }
    }
}