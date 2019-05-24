using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using Sitecore.Mvc.Presentation;

using Sitecore.Mvc;
using Sitecore.Data.Items;

namespace Helixsample.Feature.Carousel.Controllers
{
    
    public class CarouselController : Controller
    {
        // GET: Carousel

        
        public ActionResult CarouselView()

        {

            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);
            var kk = dataSource.Children;
           
            return View(kk);
           // return View();
        }
        [HttpGet]
        public ActionResult CarouselView1()

        {

            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);
            var kk = dataSource.Children;

            return View(kk);
            // return View();
        }

    }
}

