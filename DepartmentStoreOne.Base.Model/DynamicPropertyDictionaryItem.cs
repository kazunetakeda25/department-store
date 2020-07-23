using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DepartmentStoreOne.Base.Model.Common;

namespace DepartmentStoreOne.Base.Model
{
    public partial class DynamicPropertyDictionaryItem : Entity
    {
        public string PropertyId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public IList<LocalizedString> DisplayNames { get; set; } = new List<LocalizedString>();
    }
}
