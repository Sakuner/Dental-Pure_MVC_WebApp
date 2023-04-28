using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Pure.Entities
{
    public class ValidateDateRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            //TODO improve calendar
            value=(DateTime)value;
            if ( DateTime.Now.CompareTo(value)<0 && DateTime.Now.AddMonths(2).CompareTo(value)>0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("You can't choose this date");
            }
            
        }
    }
}
