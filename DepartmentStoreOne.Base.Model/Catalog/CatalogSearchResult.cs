using System.Collections.Generic;
using PagedList.Core;
using Department.Base.Model.Common;

namespace Department.Base.Model.Catalog
{
    public partial class CatalogSearchResult
    {
        public IMutablePagedList<Product> Products { get; set; }
        // Represent bucket, aggregated data based on a search query resulted by current search criteria CurrentCatalogSearchCriteria(example color 33, gr
        public IList<Aggregation> Aggregations { get; set; } = new List<Aggregation>();
    }
}
