using System.Threading.Tasks;
using Department.Base.Model.Common;

namespace Department.Base.Model.Stores
{
    public interface IStoreService
    {
        Task<Store[]> GetAllStoresAsync();
        Task<Store> GetStoreByIdAsync(string id, Currency currency = null);
    }
}
