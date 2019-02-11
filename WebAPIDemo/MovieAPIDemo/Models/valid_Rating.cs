using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieAPIDemo.Models
{
    public class valid_Rating:ValidationAttribute
    {


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var Movie = (Movie)validationContext.ObjectInstance;
            int a = Movie.Rating;
            if (a>= 0 && a<=5)
                return ValidationResult.Success;
            else
                return new ValidationResult("please enter valid date");
        }
    }
}