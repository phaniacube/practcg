using Point2Homes.Feature.Footer.Models;
using Sitecore.Data.Items;

namespace Point2Homes.Feature.Footer.Repositories
{
    public interface IFooterRepository
    {
        FooterModel GetContextItem();
    }
}
