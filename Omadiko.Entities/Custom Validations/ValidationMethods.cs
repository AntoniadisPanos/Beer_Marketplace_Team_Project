using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Omadiko.Entities.Custom_Validations
{
    public class ValidationMethods
    {
        public static ValidationResult ValidateGreaterThanZero(double value, ValidationContext context)
        {
            bool isValid = true;



            if (value <= 0)
            {
                isValid = false;
            }



            if (isValid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format($"The Field {context.MemberName} must be greater than 0"), new List<string> { context.MemberName });
            }



        }



        public static ValidationResult ValidateVolume(double value, ValidationContext context)
        {
            bool isValid = true;



            if (value <= 0.33 && value > 1.0)
            {
                isValid = false;
            }



            if (isValid)
            {
                return new ValidationResult(string.Format($"{value * 1000}" + "ml"));
            }
            else
            {
                return new ValidationResult(string.Format($"The Field {context.MemberName} must be between 0.33 and 1"), new List<string> { context.MemberName });
            }



        }



        public static ValidationResult ABVPercent(decimal value, ValidationContext context)
        {



            bool isValid = true;
            if (value < 0 && value >= 1)
            {
                isValid = false;
            }
            if (isValid)
            {
                return new ValidationResult(string.Format($"{value * 100}" + "%"));
            }
            else
            {
                return new ValidationResult(string.Format($"The Field {context.MemberName} must be between 0% and 100%"));
            }

        }



    }
}
