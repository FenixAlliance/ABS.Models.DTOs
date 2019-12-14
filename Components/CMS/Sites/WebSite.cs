using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Components.CMS.Sites
{
    public class WebPage
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string HeaderLogoURL { get; set; }
        public string FooterLogoURL { get; set; }
        public string FooterDescription { get; set; }

        public string TenantID { get; set; }


        public List<string> WebSiteForms { get; set; }
        public List<string> WebsitePosts { get; set; }
        public List<string> WebsitePages { get; set; }
        public List<string> WebsiteThemes { get; set; }
        public List<string> WebsiteForums { get; set; }

    }
}
