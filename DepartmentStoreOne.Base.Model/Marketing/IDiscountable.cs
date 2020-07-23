using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Base.Model.Common;

namespace Department.Base.Model.Marketing
{
    public interface IDiscountable
    {
        Currency Currency { get; }

        IList<Discount> Discounts { get; }

        void ApplyRewards(IEnumerable<PromotionReward> rewards);
    }
}
