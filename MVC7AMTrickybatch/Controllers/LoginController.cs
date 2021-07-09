using MVC7AMTrickybatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC7AMTrickybatch.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        // GET: Login
        EmployeeEntities db = new EmployeeEntities();

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(UserDetail user)
        {
            var userinfo = db.UserDetails.Where(u => u.UserName == user.UserName && u.Password == user.Password).SingleOrDefault();
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }
        }
        [Authorize(Roles = "Admin,Manager")]

        public ActionResult DashBoard()
        {
            return View();
        }
        [Authorize(Roles="Admin")]
        public ActionResult Contact()
        {
            return View();
        }
        [Authorize(Roles = "Manager")]

        public ActionResult About()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Login/Login");
        }
    }
}