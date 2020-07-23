using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DepartmentStoreOne.Base.Model.Common;

namespace DepartmentStoreOne.Base.Model
{
    public interface ICurrencyService
    {
        Task<Currency[]> GetAllCurrenciesAsync(Language language);
    }
}
