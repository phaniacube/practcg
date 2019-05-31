using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Helixsample.Feature.Navbar.Models
{

    using Glass.Mapper.Sc.Configuration.Attributes;

    [SitecoreType(AutoMap = true)]
    public interface Imenu
    {
        string Title { get; set; }
        string link { get; set; }
        string Desc { get; set; }
        
    }
}
