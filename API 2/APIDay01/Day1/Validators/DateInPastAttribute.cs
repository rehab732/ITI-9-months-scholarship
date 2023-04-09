using System.ComponentModel.DataAnnotations;

namespace Day1.Validators
{
    public class DateInPastAttribute: ValidationAttribute
    {
        public override bool IsValid(object? value) =>
           value is DateTime date && date < DateTime.Now;
    }
}
