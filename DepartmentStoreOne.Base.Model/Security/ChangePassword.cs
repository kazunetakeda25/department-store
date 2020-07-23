using Department.Base.Model.Common;

namespace Department.Base.Model.Security
{
    public partial class ChangePassword : ValueObject
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirm { get; set; }
    }
}
