using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoBlogSite.Controllers
{
    public class HomeController : SurfaceController
    {
        private const string PARTIA_VIEW_FOLDER = "/Views/Partials/Home/";
        public ActionResult RenderFeatured()
        {
            return PartialView(PARTIA_VIEW_FOLDER+"_Featured.cshtml");
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