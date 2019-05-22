using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Mvc.Controllers;
using System.Web.Mvc;
using System;

namespace Point2Homes.Feature.Corossel.Controllers
{
    public class CorosselController : SitecoreController
    {
        // GET: Corossel
        public ViewResult CarosselSlider()
        {
            Item contentItem = null;
            var database = Context.Database;
            if(database  != null)
            {
             if(!String.IsNullOrEmpty(
                 RenderingContext.Current.Rendering.DataSource))
                {
                    contentItem = database.GetItem(new Sitecore.Data.ID(
                        RenderingContext.Current.Rendering.DataSource));
                }
            }
            return View("CorosselSlider",contentItem);
        }
    }
}