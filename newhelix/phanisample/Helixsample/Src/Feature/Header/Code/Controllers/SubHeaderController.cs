using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helixsample.Feature.Heade.Controllers
{
    public class SubHeaderController : Controller
    {
        // GET: SubHeader
        public ActionResult Navigation()
        {
            return View("SubHeader.cshtml");
        }
    }
}