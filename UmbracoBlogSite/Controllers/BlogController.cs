using Archetype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using UmbracoBlogSite.Models;

namespace UmbracoBlogSite.Controllers
{
    public class BlogController : SurfaceController
    {
        private const string PARTIAL_VIEW_FOLDER = "/Views/Partials/Blog/";

        public ActionResult RenderBlogList()
        {
            List<BlogPreview> model = new List<BlogPreview>();
            IPublishedContent blogPage = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(x => x.DocumentTypeAlias == "blog").FirstOrDefault();

            foreach (IPublishedContent page in blogPage.Children.OrderByDescending(x=>x.UpdateDate))
            {
                string title = page.GetPropertyValue<string>("Title");
                int imageId = page.GetPropertyValue<int>("ArticleImage");
                string introduction = page.GetPropertyValue<string>("ArticleIntroduction");
                var mediaItem = Umbraco.Media(imageId);

                model.Add(new BlogPreview(page.Name,title, introduction, mediaItem.Url, page.Url));
            }
            return PartialView(PARTIAL_VIEW_FOLDER + "_BlogList.cshtml", model);
        }
    }
}