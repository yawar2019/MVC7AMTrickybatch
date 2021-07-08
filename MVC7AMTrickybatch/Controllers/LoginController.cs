using MVC7AMTrickybatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7AMTrickybatch.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDetail user)
        {
            var userinfo = db.UserDetails.Where(u => u.UserName == user.UserName && u.Password == user.Password).SingleOrDefault();
            if (userinfo != null)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }
        }

    }
}