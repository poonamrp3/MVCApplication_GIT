using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NetCore_Traning2.CustomValidation;

namespace NetCore_Traning2.Models
{
    public class Product
    {
        [Required]
        [DisplayName("Product ID")]
        public int ProductId { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z]+$")]
        [DisplayName("Product Name")]
        [CustomValidators_Product(ErrorMessage ="Product Name can not start with P",Character ="P")]
        public string ProductName { get; set; }

        [Required]
        [DisplayName("Product Code")]
        public string ProductCode { get; set; }

        [Required]
        [DisplayName("Product Price")]
        public decimal Price { get; set; }
    }
}
