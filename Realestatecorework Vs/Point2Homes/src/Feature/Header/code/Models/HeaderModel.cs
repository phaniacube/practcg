using Sitecore.Data.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Point2Homes.Feature.Header.Models
{
    public class HeaderModel
    {
        public ImageField LogoImage { get; set; }
        public LinkField LogoLink { get; set; }
        public string WaterMarktext { get; set; }
        public string SearchButtontext { get; set; }
        public string HomeMenu { get; set; }
        public string AboutMenu { get; set; }
        public string PropertyMenu { get; set; }
        public string ContactMenu { get; set; }
        public MultilistField PagesMenu { get; set; }
        public string PagesTextMenu { get; set; }
        public string ServicesMenu { get; set; }
    }
}