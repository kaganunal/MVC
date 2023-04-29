using System.ComponentModel.DataAnnotations;

namespace MVCAlgorithms.CustomValidations
{
    public class IdentificationValidation : ValidationAttribute
    {
        protected override ValidationResult
                IsValid(object value, ValidationContext validationContext)
        {
            string identification = (string)value;

            // Check if the identification number is null or empty
            if (string.IsNullOrEmpty(identification))
            {
                return new ValidationResult("Identification number cannot be empty.");
            }

            // Check if the identification number has exactly 11 digits
            if (identification.Length != 11)
            {
                return new ValidationResult("Identification number must be exactly 11 digits.");
            }

            // Check if the first digit of the identification number is 0
            if (identification.StartsWith("0"))
            {
                return new ValidationResult("Identification number cannot start with 0.");
            }

            // Convert the identification number digits to integers
            int[] digits = new int[11];
            for (int i = 0; i < 11; i++)
            {
                if (!int.TryParse(identification[i].ToString(), out digits[i]))
                {
                    return new ValidationResult("Identification number contains non-numeric characters.");
                }
            }

            // Calculate the first checksum
            int firstChecksum = 0;
            for (int i = 0; i < 9; i += 2)
            {
                firstChecksum += digits[i];
            }
            firstChecksum *= 7;
            firstChecksum -= digits[1] + digits[3] + digits[5] + digits[7];
            firstChecksum %= 10;

            // Calculate the second checksum
            int secondChecksum = 0;
            for (int i = 0; i < 10; i++)
            {
                secondChecksum += digits[i];
            }
            secondChecksum %= 10;

            // Check if the calculated checksums match the last digit of the identification number
            if (firstChecksum != digits[9] || secondChecksum != digits[10])
            {
                return new ValidationResult("Identification number is invalid.");
            }

            return ValidationResult.Success;

        }
    }
}
