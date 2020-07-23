using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Base.Model.Stores;

namespace Department.Base.Model.LinkList.Services
{
    public interface IMenuLinkListService
    {
        IList<MenuLinkList> LoadAllStoreLinkLists(Store store, Language language);
        Task<IList<MenuLinkList>> LoadAllStoreLinkListsAsync(Store store, Language language);
    }
}
