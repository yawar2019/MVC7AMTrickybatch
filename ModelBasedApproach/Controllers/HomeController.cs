using ModelBasedApproach.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            EmployeeModelContainer db = new Models.EmployeeModelContainer();
            ViewBag.Employees = new SelectList(db.Employeeinfoes, "EmpId", "EmpName",3);
            return View(reg);
        }
        [HttpPost]
        public ActionResult HtmlHelperExample(string EmpName,int Employees)
        {
            
            EmployeeModelContainer db = new Models.EmployeeModelContainer();
            ViewBag.Employees = new SelectList(db.Employeeinfoes, "EmpId", "EmpName", 3);
            var selected = db.Employeeinfoes.Where(s => s.EmpId == Employees).SingleOrDefault();
            ViewBag.msg = EmpName+","+ selected.EmpName;
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index2(HttpPostedFileBase fileupload)
        {
            string filename = Path.GetFileName(fileupload.FileName);
            string path = Server.MapPath("~/Upload");
            fileupload.SaveAs(Path.Combine(path, filename));
            ViewBag.msg = "uploaded successfully";

            return View();
        }

    }
}