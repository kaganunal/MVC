using System.ComponentModel.DataAnnotations;

namespace Onur_Hoca_MVC.CustomValidations
{
    public class JoinDateValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime _dateJoin = Convert.ToDateTime(value);
            if (_dateJoin <= DateTime.Now && _dateJoin > DateTime.Now.AddYears(-10))
            {
                return ValidationResult.Success;
            }
            else if (_dateJoin > DateTime.Now)
            {
                return new ValidationResult("Join date cannot be greater than current date");
            }
            return base.IsValid(value, validationContext);
        }
    }
}
