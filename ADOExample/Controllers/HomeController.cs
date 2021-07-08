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
        //[HttpPost]
        //public ActionResult Create(string EmpName,int EmpSalary)
        //{
        //    return View();
        //}
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        //[HttpPost]
        //public ActionResult Create(FormCollection frm)
        //{
        //    string Name = frm["EmpName"];
        //    int EmpSalary = Convert.ToInt32(frm["EmpSalary"]);
        //    return View();
        //}
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp =db.GetEmployeeById(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult TestLayout()
        {
            
            return View();
        }
    }
}