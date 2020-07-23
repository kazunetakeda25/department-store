using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DepartmentStoreOne.Base.Model.Common;

namespace DepartmentStoreOne.Base.Model
{
    public interface IHasSettings
    {
        IMutablePagedList<SettingEntry> Settings { get; }
    }
}
