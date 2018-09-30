using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoBlogSite.Models
{
    public class BlogPreview
    {

        public string Name { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string ImageUrl { get; set; }
        public string LinkUrl { get; set; }

        public BlogPreview(string name,string title, string introduction, string imageUrl, string linkUrl)
        {
            Name = name;
            Title = title;
            Introduction = introduction;
            ImageUrl = imageUrl;
            LinkUrl = linkUrl;
        }
    }
}