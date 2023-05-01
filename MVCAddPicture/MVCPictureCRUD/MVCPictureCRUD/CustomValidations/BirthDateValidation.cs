using System.ComponentModel.DataAnnotations;

namespace MVCPictureCRUD.CustomValidations
{
    public class BirthDateValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            DateTime? date = Convert.ToDateTime(value);

            if (date < DateTime.Now && date > DateTime.UtcNow.AddYears(-50))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
