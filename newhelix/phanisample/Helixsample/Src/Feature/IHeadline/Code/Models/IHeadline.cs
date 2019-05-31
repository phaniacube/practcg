using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Fields;
using Glass.Mapper.Sc.Fields;

namespace Helixsample.Feature.IHeadline.Models
{
    public class IHeadline
    {

        public Image Image { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
    }
}