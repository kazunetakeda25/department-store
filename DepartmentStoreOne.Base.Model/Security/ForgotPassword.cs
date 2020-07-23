using System.ComponentModel.DataAnnotations;
using Department.Base.Model.Common;

namespace Department.Base.Model.Security
{
    public partial class ForgotPassword : ValueObject
    {
        [Required(ErrorMessage = "A Email is required")]
        public string Email { get; set; }
    }
}
