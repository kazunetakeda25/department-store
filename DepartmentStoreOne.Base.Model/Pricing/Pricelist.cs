using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Base.Model.Common;

namespace Department.Base.Model.Pricing
{
    public partial class Pricelist
    {
        public Pricelist(Currency currency)
        {
            Currency = currency;
        }
        public string Id { get; set; }
        public Currency Currency { get; set; }
    }
}
