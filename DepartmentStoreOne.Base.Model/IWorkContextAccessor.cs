using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentStoreOne.Base.Model
{
    public interface IWorkContextAccessor
    {
        WorkContext WorkContext { get; set; }
    }
}
