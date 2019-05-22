using Point2Homes.Feature.Header.Repositories;
using Sitecore.Data.Fields;
using System.Collections.Generic;
using System.Web.Mvc;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Point2Homes.Feature.Header.Models;
using System.Linq;

namespace Point2Homes.Feature.Header.Controllers
{
    public class HeaderController : Controller
    {
        private IHeaderRepository HeaderRepository { get; set; }

        public HeaderController(IHeaderRepository headerRepository)
        {
            this.HeaderRepository = headerRepository;
        }

        public ActionResult HeaderLayout()
        {
            
                    IEnumerable<Item> pagemultiList = null;
                    var pagemultiListField = new MultilistField(
                      RenderingContext.Current.Rendering.Item.Fields[Templates.Header.Fields.PagesMenu.ToString()]
                       );

                    if (pagemultiListField != null)
                    {
                        pagemultiList = pagemultiListField.GetItems();


                        if (pagemultiList != null)
                        {
                         ViewBag.subMenu = pagemultiList;                      
                        }
                        
                    }

           return View(this.HeaderRepository.GetContextItem());
        }
    }
}