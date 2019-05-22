using Sitecore.Data.Items;

namespace Point2Homes.Feature.Header.Repositories
{
    public interface IHeaderRepository
    {
        Item GetContextItem();
    }
}
