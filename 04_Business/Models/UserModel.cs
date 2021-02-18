using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AppCore.Records.Bases;

namespace _04_Business.Models
{
    public class UserModel : RecordBase
    {
        [Required(ErrorMessage = "User Name is required!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long." , MinimumLength = 6)]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The email address is required!")]
        [DisplayName("Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "The Confirm Password is required!")]
        [DisplayName("Confirm Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public bool Active { get; set; }

        public int RoleId { get; set; }

        public RoleModel Role { get; set; }
    }
}
