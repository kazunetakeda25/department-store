using System.Collections.Generic;

namespace Department.Base.Model.Security
{
    public class PasswordChangeResult
    {
        public bool? Succeeded { get; set; }
        public IList<FormError> Errors { get; set; } = new List<FormError>();
    }
}
