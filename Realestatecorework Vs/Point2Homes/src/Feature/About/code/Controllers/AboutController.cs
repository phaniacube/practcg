using Point2Homes.Feature.About.Repositories;
using Sitecore.Data.Fields;
using System.Collections.Generic;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;
using Point2Homes.Feature.About.Models;
using System.Web.Mvc;

namespace Point2Homes.Feature.About.Controllers
{
    public class AboutController : Controller
    {
        private IAboutRepositoty aboutRepository;
        public AboutController(IAboutRepositoty aboutrepository)
        {
            this.aboutRepository = aboutrepository;
            
        }
        public ActionResult AboutUs()
        {

            IEnumerable<Item> pagemultiList = null;
            var pagemultiListField = new MultilistField(
              RenderingContext.Current.Rendering.Item.Fields[TemplatesAbout.About.Property.Fields.PropertyDetail.ToString()]
               );

            if (pagemultiListField != null)
            {
                pagemultiList = pagemultiListField.GetItems();


                if (pagemultiList != null)
                {
                    ViewBag.subMenu = pagemultiList;
                }

            }
            return View(this.aboutRepository.Get());
        }
    }
}