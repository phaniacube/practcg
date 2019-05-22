using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Point2Homes.Feature.Header.Models
{
    public class PageHeaderModel
    {
        public IEnumerable<PageSubHeaderModel> PageSubMenu { get; set; }
    }
}