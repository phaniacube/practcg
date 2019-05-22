
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Point2Homes.Feature.About.Models
{
    using Glass.Mapper.Sc.Configuration.Attributes;

    [SitecoreType(AutoMap = true)]
    public class AboutModel
    {
        public string Title { get; set; }
        public string PropertyTitle { get; set; }
       
        public DateTime PropertyDate { get; set; }
        public string PropertySummary { get; set; }
        public string PropertyImage { get; set; }
        
    }
}