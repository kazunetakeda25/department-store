using System.Collections.Generic;

namespace Department.Base.Model.Security
{
    public class ChangeTwoFactorAuthenticationResult
    {
        public bool? Succeeded { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public string VerificationUrl { get; set; }
    }
}
