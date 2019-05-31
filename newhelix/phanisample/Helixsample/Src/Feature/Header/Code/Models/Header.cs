using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Fields;
using Glass.Mapper.Sc.Fields;
namespace Helixsample.Feature.Heade.Models
{
    public class Header
    {
        public Image Logo { get; set; }
        public string Title { get; set; }

        public string Description{ get; set; }
        
    }
}