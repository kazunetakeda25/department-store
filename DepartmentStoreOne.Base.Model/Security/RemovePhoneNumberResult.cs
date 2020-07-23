using System.Collections.Generic;

namespace Department.Base.Model.Security
{
    public class RemovePhoneNumberResult
    {
        public bool? Succeeded { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
