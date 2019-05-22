using Point2Homes.Foundation.DependencyInjection;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Point2Homes.Feature.Header.Repositories
{
    [Service(typeof(IHeaderRepository))]
    public class HeaderRepository : IHeaderRepository
    {
        public Item GetContextItem()
        {
            return RenderingContext.Current.Rendering.Item;
        }
    }
}