using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Base.Model.Recommendations
{
    public interface IRecommendationProviderFactory
    {
        IRecommendationsProvider GetProvider(string providerName);
    }
}
