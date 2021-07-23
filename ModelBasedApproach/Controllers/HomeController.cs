using ModelBasedApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBasedApproach.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegisterModel reg)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View(reg);
            }
        }
        public ActionResult HtmlHelperExample()
        {
            RegisterModel reg = new Models.RegisterModel();
            reg.UserName = "Jyothi";
            return View(reg);
        }

    }
}