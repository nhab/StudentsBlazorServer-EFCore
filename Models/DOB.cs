using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorForms.Models
{
    public class DOB : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToDateTime(value) > DateTime.Now)
                return new ValidationResult("Date of Birth cannot be in future", new[] { validationContext.MemberName });
            else if (Convert.ToDateTime(value) < new DateTime(2015, 1, 1))
                return new ValidationResult("Date of Birth should not be before 2015", new[] { validationContext.MemberName });
            else
                return ValidationResult.Success;
        }
    }
}
