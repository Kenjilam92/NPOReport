using System;
using System.ComponentModel.DataAnnotations;

namespace reportNPO.Models.Validation
{
    public class FutureAttirbute:ValidationAttribute

    {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("This can't be empty");
            }
            if ( (DateTime)value < DateTime.Now )
                return new ValidationResult ("You can only add date from the future.");
            return ValidationResult.Success;
        }
    }
}