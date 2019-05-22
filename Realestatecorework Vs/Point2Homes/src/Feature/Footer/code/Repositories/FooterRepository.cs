                                            using Point2Homes.Foundation.DependencyInjection;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Point2Homes.Feature.Footer.Models;

namespace Point2Homes.Feature.Footer.Repositories
{
    [Service(typeof(IFooterRepository))]
    public class FooterRepository : IFooterRepository
    {
        public FooterModel GetContextItem()
        {
            Item dataSource = RenderingContext.Current.Rendering.Item;

            if (dataSource != null && dataSource.Versions.Count > 0)
            {
                var modelfooter = new FooterModel
                {
                    FollowText = dataSource.Fields[TemplatesFooter.Footer.Fields.FollowText].Value,
                    FBImage = dataSource.Fields[TemplatesFooter.Footer.Fields.FBImage],
                    TwitterImage = dataSource.Fields[TemplatesFooter.Footer.Fields.TwitterImage],
                    InstagramImage = dataSource.Fields[TemplatesFooter.Footer.Fields.DribbleImage],
                    GoogleplusImage = dataSource.Fields[TemplatesFooter.Footer.Fields.GoogleplusImage],
                    Rights = dataSource.Fields[TemplatesFooter.Footer.Fields.Rights].Value,
                    DesignLink = dataSource.Fields[TemplatesFooter.Footer.Fields.DesignLink].Value,
                    FBLinkImage = dataSource.Fields[TemplatesFooter.Footer.Fields.FBLink],
                    InstagramUrl = dataSource.Fields[TemplatesFooter.Footer.Fields.instagramlinkurl],
                    GoogleplusUrl = dataSource.Fields[TemplatesFooter.Footer.Fields.GoogleplusUrl],
                    TwitterUrl = dataSource.Fields[TemplatesFooter.Footer.Fields.TwitterUrl]
                    
                };

                return modelfooter;
            }
            return null;
        }
    }
}