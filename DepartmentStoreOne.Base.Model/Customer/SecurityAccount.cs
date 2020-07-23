using System;
using System.Collections.Generic;
using System.Text;
using Department.Base.Model.Common;

namespace Department.Base.Model.Customer
{
    public class SecurityAccount : Entity
    {
        public string UserName { get; set; }
        public bool IsLockedOut { get; set; }
        public IList<string> Roles { get; set; }
    }
}
