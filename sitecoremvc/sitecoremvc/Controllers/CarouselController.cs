using Sitecore.Mvc.Presentation;
using sitecoremvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Mvc;
using Sitecore.Data.Items;

namespace sitecoremvc.Controllers
{
    public class CarouselController : Controller
    {
        // GET: Carousel
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Carouselimg()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);
            var kk = dataSource.Children;
              var viewModel = new CarouselModel
            {
               // ImageField = dataSource.Children
            };
            return View(viewModel);

           
        }
    }
}