using System.Collections.Generic;
using System.Threading.Tasks;
using PagedList.Core;
using Department.Base.Model.Catalog;

namespace Department.Base.Model.Inventory.Services
{
    public interface IInventoryService
    {
        Task EvaluateProductInventoriesAsync(IEnumerable<Product> products, WorkContext workContext);
        Task<FulfillmentCenter> GetFulfillmentCenterByIdAsync(string id);
        IPagedList<FulfillmentCenter> SearchFulfillmentCenters(FulfillmentCenterSearchCriteria criteria);
        Task<IPagedList<FulfillmentCenter>> SearchFulfillmentCentersAsync(FulfillmentCenterSearchCriteria criteria);

    }
}
