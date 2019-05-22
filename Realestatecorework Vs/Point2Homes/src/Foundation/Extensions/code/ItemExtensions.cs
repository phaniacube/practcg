using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Point2Homes.Foundation.Extensions
{
    public static class ItemExtensions
    {
        public static string LinkFieldurl(this Item item, ID fieldID)
        {
            if (item == null)
            {
                return string.Empty;
            }
            if (ID.IsNullOrEmpty(fieldID))
            {
                throw new ArgumentNullException(nameof(fieldID));
            }
            LinkField field = item.Fields[fieldID];
            return field?.GetFriendlyUrl() ?? string.Empty;
        }
    }
}