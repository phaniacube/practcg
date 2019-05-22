using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Point2Homes.Feature.Footer.Models
{
    public class FooterModel
    {
        public string FollowText { get; set; }
        public ImageField FBImage { get; set; }
        public ImageField TwitterImage { get; set; }
        public ImageField InstagramImage { get; set; }
        public ImageField GoogleplusImage { get; set; }
        public string Rights { get; set; }
        public string DesignLink { get; set; }
        public LinkField FBLinkImage { get; set; }
        public LinkField InstagramUrl { get; set; }
        public LinkField GoogleplusUrl { get; set; }

        public LinkField TwitterUrl { get; set; }
    }
}