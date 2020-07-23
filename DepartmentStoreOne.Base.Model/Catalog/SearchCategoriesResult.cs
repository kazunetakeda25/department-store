using PagedList.Core;

namespace Department.Base.Model.Catalog
{
    public class SearchCategoriesResult
    {
        public IPagedList<Category> Categories { get; set; }
        public IPagedList MetaData { get; set; }
    }
}
