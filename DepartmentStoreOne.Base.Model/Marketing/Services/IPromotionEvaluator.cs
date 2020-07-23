using System.Collections.Generic;
using System.Threading.Tasks;

namespace Department.Base.Model.Marketing.Services
{
    public interface IPromotionEvaluator
    {
        Task EvaluateDiscountsAsync(PromotionEvaluationContext context, IEnumerable<IDiscountable> owners);
    }
}
