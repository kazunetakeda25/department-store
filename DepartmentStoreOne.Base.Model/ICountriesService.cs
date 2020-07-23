using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreOne.Base.Model
{
    public interface ICountriesService
    {
        Task<IList<Country>> GetCountriesAsync();
    }
}
