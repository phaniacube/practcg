using Point2Homes.Foundation.DependencyInjection;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Point2Homes.Feature.About.Repositories
{
    [Service(typeof(IAboutRepositoty))]
    public class AboutRepository : IAboutRepositoty
    {
        public Item Get()
        {
            return RenderingContext.Current.Rendering.Item;
        }
        
    }
}