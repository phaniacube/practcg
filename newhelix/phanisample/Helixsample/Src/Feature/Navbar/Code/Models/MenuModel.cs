using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Fields;
namespace Helixsample.Feature.Navbar.Models
{
    using Glass.Mapper.Sc.Configuration;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using Glass.Mapper.Sc.Fields;

    [SitecoreType(AutoMap = true)]
    public class MenuModel
    {
         public string Title { get; set; }

        [SitecoreField(FieldType = SitecoreFieldType.GeneralLink)]
        public Link link { get; set; }
        
        public string Desc { get; set; }
        
    }
    public class Footer
    {
        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<MenuModel> Children { get; set; }

    }

}
  