using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NetCore_Traning.Models
{
    public class Product
    {
        [DisplayName("Product ID")]
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Code")]
        public string ProductCode { get; set;}

        [DisplayName("Product Price")]
        public decimal Price { get; set; }
    }
}