using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Department.Base.Model.Common;

namespace Department.Base.Model.Security
{
    public partial class UsersInvitation : ValueObject
    {
        public string Message { get; set; }
        public IList<string> Roles { get; set; }
        [Required]
        public IList<string> Emails { get; set; }
    }
}
