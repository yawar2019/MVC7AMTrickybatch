using ADOExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADOExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private EmployeeContext db = new EmployeeContext(); 
        public ActionResult Index()
        {
            return View(db.GetAllEmployees());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            return View();
        }
    }
}