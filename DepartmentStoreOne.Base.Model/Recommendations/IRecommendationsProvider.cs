using System.Collections.Generic;
using System.Threading.Tasks;
using Department.Base.Model.Catalog;

namespace Department.Base.Model.Recommendations
{
    public interface IRecommendationsProvider
    {
        string ProviderName { get; }
        RecommendationEvalContext CreateEvalContext();
        Task<Product[]> GetRecommendationsAsync(RecommendationEvalContext context);
        Task AddEventAsync(IEnumerable<UsageEvent> @events);
    }
}
