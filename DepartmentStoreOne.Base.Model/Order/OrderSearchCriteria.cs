using System.Collections.Specialized;
using Department.Base.Model.Common;

namespace Department.Base.Model.Order
{
    public partial class OrderSearchCriteria : PagedSearchCriteria
    {
        private static int _defaultPageSize = 20;

        public static int DefaultPageSize
        {
            get { return _defaultPageSize; }
            set { _defaultPageSize = value; }
        }

        public OrderSearchCriteria()
            : base(new NameValueCollection(), _defaultPageSize)
        {
        }
        public OrderSearchCriteria(NameValueCollection queryString)
            : base(queryString, DefaultPageSize)
        {
        }

        public string CustomerId { get; set; }
        public string Sort { get; set; }
    }
}

