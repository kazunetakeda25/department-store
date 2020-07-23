using System;
using Department.Base.Model.Common;

namespace Department.Base.Model.Cart
{
    public partial class CartShipmentItem : Entity
    {
        public LineItem LineItem { get; set; }
        public int Quantity { get; set; }
        public override object Clone()
        {
            var result = base.Clone() as CartShipmentItem;

            result.LineItem = LineItem?.Clone() as LineItem;
            return result;
        }

    }
}
