using System.Collections.Generic;
using Department.Base.Model.Common;

namespace Department.Base.Model.Security
{
    public class Role : Entity
    {
        public string Name { get; set; }
        public IList<string> Permissions { get; set; } = new List<string>();
    }
}
