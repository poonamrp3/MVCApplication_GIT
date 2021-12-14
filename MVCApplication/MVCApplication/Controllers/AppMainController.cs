using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class AppMainController : Controller
    {
        // GET: AppMain
        public ActionResult Information()
        {
            return View();
        }

        public ActionResult Login()
        {
            Login l = new Login();
            return View(l);
        }

        public ActionResult Register()
        {
            Login l = new Login();
            return View(l);
        }

        [HttpPost]
        public ActionResult Submit(Login p_LoginInfo)
        {
            Login l = new Login();
            return View(l);
        }

        [HttpPost]
        public ActionResult Reg_Submit(Login p_Info)
        {
            Login l = new Login();
            return View(l);
        }

    }
}