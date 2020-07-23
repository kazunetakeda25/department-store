using System.Collections.Generic;
using System.Threading.Tasks;

namespace Department.Base.Model.Marketing.Services
{
    public interface IDynamicContentEvaluator
    {
        Task<IEnumerable<DynamicContentItem>> EvaluateDynamicContentItemsAsync(DynamicContentEvaluationContext context);
    }
}
