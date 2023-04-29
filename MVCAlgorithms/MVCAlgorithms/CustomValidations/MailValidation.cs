using System.ComponentModel.DataAnnotations;

namespace MVCAlgorithms.CustomValidations
{
    public class MailValidation : ValidationAttribute
    {
        protected override ValidationResult
                IsValid(object value, ValidationContext validationContext)
        {
            string email = value as string;

            if (email != null && email.IndexOf("@") > 0 && email.EndsWith("@bilgeadam.com") && email.IndexOf("@") == email.LastIndexOf("@"))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Wrong E-mail format!");
            }
        }
    }
}

