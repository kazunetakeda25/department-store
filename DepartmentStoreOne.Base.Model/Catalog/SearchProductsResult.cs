using System.Collections.Generic;
using PagedList.Core;

namespace Department.Base.Model.Catalog
{
    public class SearchProductsResult
    {
        public IPagedList<Product> Products { get; set; }
        public IList<Aggregation> Aggregations { get; set; }
        public IPagedList MetaData { get; set; }
    }
}
