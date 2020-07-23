using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Base.Model.Common.Exceptions
{
    public class BaseException : Exception
    {
        public string View { get; set; }

        public BaseException(string message)
           : this(message, null)
        {
        }
        public BaseException(string message, string view)
            : this(message, null, view)
        {
        }

        public BaseException(string message, Exception innerException, string view)
            : base(message, innerException)
        {
            View = view;
        }
    }
}
