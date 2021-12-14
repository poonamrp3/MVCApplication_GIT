using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NetCore_Traning2.Models;

namespace NetCore_Traning2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Save(Product product)
        {
            if (ModelState.IsValid) 
            {
                return View("Thankyou", product);
            }
            else
            {
                return View("Create");
            }
        }

        public IActionResult ProductList()
        {
            return View();
        }
    }
}