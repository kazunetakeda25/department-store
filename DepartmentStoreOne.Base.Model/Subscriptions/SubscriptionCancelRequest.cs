using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Base.Model.Subscriptions
{
    public partial class SubscriptionCancelRequest
    {
        public string CustomerId { get; set; }
        public string SubscriptionId { get; set; }
        public string Number { get; set; }
        public string CancelReason { get; set; }
    }
}
