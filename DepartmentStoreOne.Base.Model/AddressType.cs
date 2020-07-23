using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentStoreOne.Base.Model
{
    [Flags]
    public enum AddressType
    {
        Billing = 1,
        Shipping = 2,
        BillingAndShipping = Billing | Shipping
    }
}