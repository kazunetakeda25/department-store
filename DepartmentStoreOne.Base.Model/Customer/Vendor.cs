using System.Collections.Generic;
using Department.Base.Model.Catalog;
using Department.Base.Model.Common;
using Department.Base.Model.Customer;

namespace Department.Base.Model
{
    public partial class Vendor : Member
    {
        public string Description { get; set; }

        public string SiteUrl { get; set; }

        public string LogoUrl { get; set; }

        public string GroupName { get; set; }

        /// <summary>
        /// Vendor seo info
        /// </summary>
        public SeoInfo SeoInfo { get; set; }

        public IMutablePagedList<Product> Products { get; set; }

        public string Handle => SeoInfo?.Slug ?? Id;
    }
}
