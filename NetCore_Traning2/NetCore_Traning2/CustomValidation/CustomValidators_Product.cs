using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace NetCore_Traning2.CustomValidation
{
    public class CustomValidators_Product : ValidationAttribute
    {
        //public override bool IsValid(object value)
        //{
        //    string strvalue = value.ToString();
        //    if(strvalue.Length > 6)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        public string Character { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string data = (string)value;
            if (!string.IsNullOrEmpty(data))
            {
                if (data.StartsWith(Character, StringComparison.InvariantCultureIgnoreCase))
                {
                    return ValidationResult.Success;
                }
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}
