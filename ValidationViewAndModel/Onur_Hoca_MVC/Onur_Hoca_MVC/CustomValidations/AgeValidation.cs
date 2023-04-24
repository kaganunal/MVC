using System.ComponentModel.DataAnnotations;

namespace Onur_Hoca_MVC.CustomValidations
{
    public class AgeValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int _age = Convert.ToInt32(value);
            if (_age >= 18 && _age < 42)
            {
                return ValidationResult.Success;
            }
            else if (_age < 18)
            {
                return new ValidationResult("Age cannot be lower than 18");
            }
            else if (_age > 42)
            {
                return new ValidationResult("Age cannot be greater than 42");
            }
            else
            {
                return new ValidationResult("Wrong format");
            }
        }


    }
}
