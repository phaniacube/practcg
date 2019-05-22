using System.Web.Mvc;
using Point2Homes.Feature.Footer.Repositories;
using Point2Homes.Feature.Footer.Models;
using Sitecore.Data;
using System;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;

namespace Point2Homes.Feature.Footer.Controllers
{
    public class FooterController : Controller
    {
        private IFooterRepository FooterRepository { get; set; }

        public FooterController(IFooterRepository footerRepository)
        {
            this.FooterRepository = footerRepository;
        }

        public ActionResult FooterLayout()
        {
            //Item item = Sitecore.Context.Database.GetItem("/sitecore/content/Reality/DataSources/Footer/Footer Content");
            ////Sitecore.Data.Items.Item instalink = item.Children["instagram url:"];
            //LinkField linkField = item.Fields["{0595F627-C1BA-4D57-983F-3FD890BE2F95}"];
            //string url1 = LinkManager.GetItemUrl(Sitecore.Context.Database.GetItem(linkField.Url));
            //string url = linkField.Url;
            //var modelfooter = new FooterModel
            //{
            //    FollowText = TemplatesFooter.Footer.Fields.FollowText.ToString(),
            //    FBLink = TemplatesFooter.Footer.Fields.FBLink.ToString(),
            //    TwitterLink = TemplatesFooter.Footer.Fields.TwitterLink.ToString(),
            //    DribbleLink = TemplatesFooter.Footer.Fields.DribbleLink.ToString(),
            //    Googlepluslink = TemplatesFooter.Footer.Fields.Googlepluslink.ToString(),
            //    Rights = TemplatesFooter.Footer.Fields.Rights.ToString(),
            //    DesignLink = TemplatesFooter.Footer.Fields.DesignLink.ToString(),
            //    FBLinkImage = TemplatesFooter.Footer.Fields.FBLinkImage.ToString(),
            //    //instagramurl = TemplatesFooter.Footer.Fields.instagramlinkurl
            //};
            
            return View(this.FooterRepository.GetContextItem());
        }
    }
}