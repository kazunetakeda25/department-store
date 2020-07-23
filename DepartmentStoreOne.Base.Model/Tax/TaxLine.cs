using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Base.Model.Common;

namespace Department.Base.Model
{
    public partial class TaxLine : Entity
    {
        public TaxLine(Currency currency)
        {
            Amount = new Money(currency);
            Price = new Money(currency);
        }
        /// <summary>
        /// represent  original object code (lineItem, shipment etc)
        /// </summary>
        public string Code { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Tax line total amount
        /// </summary>
        public Money Amount { get; set; }

        public int Quantity { get; set; }
        /// <summary>
        /// Tax line one item price
        /// </summary>
        public Money Price { get; set; }
        public string TaxType { get; set; }
    }
}
