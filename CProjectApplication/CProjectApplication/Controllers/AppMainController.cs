using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CProjectApplication.Controllers
{
    public class AppMainController : Controller
    {
        public IActionResult ImageInformation()
        {
            return View("InformationPage");
        }
    }
}