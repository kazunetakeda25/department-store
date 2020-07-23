using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Department.Base.Model.Security
{
    public class UpdatePhoneNumberModel
    {
        [Required]
        [FromForm(Name = "customer[phoneNumber]")]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
