using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Base.Model.Common
{
    public interface IConvertible<T>
    {
        T ConvertTo(Currency currency);
    }
}
