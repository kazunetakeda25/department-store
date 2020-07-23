using System.Collections.Generic;
using Department.Base.Model.Stores;

namespace Department.Base.Model.StaticContent
{
    /// <summary>
    /// Represent a search and rendering static content pages (pages and blogs etc)
    /// </summary>
    public interface IStaticContentService
    {
        IEnumerable<ContentItem> LoadStoreStaticContent(Store store);
    }
}
