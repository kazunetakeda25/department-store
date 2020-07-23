using System.Collections.Generic;
using DepartmentStoreOne.Base.Model.Common;

namespace DepartmentStoreOne.Base.Model
{
    public partial class ContactForm : ValueObject
    {
        public ContactForm()
        {
            Contact = new Dictionary<string, string[]>();
        }

        public IDictionary<string, string[]> Contact { get; set; }

        public string FormType { get; set; }
    }
}
