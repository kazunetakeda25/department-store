using System.ComponentModel.DataAnnotations;

namespace Department.Base.Model.Security
{
    public partial class OrganizationRegistration : UserRegistration
    {
        
        public string OrganizationName { get; set; }
    }
}
