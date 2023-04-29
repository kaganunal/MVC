using MVCAlgorithms.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace MVCAlgorithms.Models
{
    public class User
    {
        [StringLength(50)]
        [Required(ErrorMessage = "Username can not be empty!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email can not be empty!")]
        [MailValidation]
        public string UserEmail { get; set; }
        [IdentificationValidation]
        [Required]
        public string IdentificationNumber { get; set; }
        [Required]
        [RegularExpression("[0-9]{4}", ErrorMessage = "User code is invalid!")]
        public int UserCode { get; set; }
        [Required]
        [Range(18, 45)]
        public int Age { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Passwords are not same!")]
        public string PasswordRepeat { get; set; }
    }
}
