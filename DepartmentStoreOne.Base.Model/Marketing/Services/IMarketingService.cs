using System;
using System.Threading.Tasks;

namespace Department.Base.Model.Services
{
    public interface IMarketingService
    {
        [Obsolete("Use IDynamicContentEvaluator instead")]
        Task<string> GetDynamicContentHtmlAsync(string storeId, string placeholderName);
    }
}
