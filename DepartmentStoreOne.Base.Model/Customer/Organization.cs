using System.Runtime.Serialization;
using Newtonsoft.Json;
using Department.Base.Model.Common;

namespace Department.Base.Model.Customer
{
    public partial class Organization : Member
    {
        /// <summary>
        /// Organization contacts
        /// </summary>
        [JsonIgnore]
        [IgnoreDataMember]
        public IMutablePagedList<Contact> Contacts { get; set; }
    }
}
