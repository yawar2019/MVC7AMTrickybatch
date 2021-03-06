using MVC7AMTrickybatch.Filters;
using MVC7AMTrickybatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7AMTrickybatch.Controllers
{
    
    public class NewController : Controller
    {
        // GET: New
     
        public string Number()
        {
             int a = 10;
            return "hello";
        }

        public int Number1()
        {
            return 1211;
        }

        public string Number3(int? id)
        {
            return "My Employee Id is " + id;
        }
        public string Number4(int? sid)
        {
            return "My Roll no is " + sid;
        }
        public string Number5(int? sid, string Name)
        {
            return "My Roll no is " + sid + " My Name is" + Name;
        }
        public string Number6(int? sid)
        {
            return "My Roll no is " + sid + " My Name is" + Request.QueryString["Name"] + "Designation is " + Request.QueryString["Designation"];
        }
        public ActionResult getView()
        {
            return View();

        }

        public ActionResult getView1()
        {
            return View("TestView");

        }

        public ActionResult getView2()
        {
            return View("~/Views/Default/Index.cshtml");
        }
        public ActionResult getView3()
        {
            ViewBag.info = "Mallesh";
            return View();
        }
        public ActionResult getView4()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Balu";
            obj.EmpSalary = 50000;

            ViewBag.info = obj;

            return View();
        }

        public ActionResult getView5()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Balu";
            obj.EmpSalary = 3450000;


            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Mallesh";
            obj1.EmpSalary = 230000;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "jyothi";
            obj2.EmpSalary = 3250000;

            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            ViewBag.info = listObj;

            return View();
        }

        public ActionResult getView6()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Balu";
            obj.EmpSalary = 50000;

            //object model = obj;                 

            return View(obj);
        }

        public ActionResult getView7()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Balu";
            obj.EmpSalary = 3450000;


            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Mallesh";
            obj1.EmpSalary = 230000;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "jyothi";
            obj2.EmpSalary = 3250000;

            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            return View(listObj);
        }

        public ActionResult getView8(int? id)
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Balu";
            obj.EmpSalary = 3450000;


            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Mallesh";
            obj1.EmpSalary = 230000;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "jyothi";
            obj2.EmpSalary = 3250000;

            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            DepartmentModel dept = new DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Account";

            List<DepartmentModel> listdept = new List<DepartmentModel>();
            listdept.Add(dept);
            listdept.Add(dept1);

            EmployeeandDepartments empdeptObj = new EmployeeandDepartments();
            empdeptObj.Emp = listObj;
            empdeptObj.Dept = listdept;


            return View(empdeptObj);
        }

        public ViewResult getView9(int id)
        {
            DepartmentModel dept = new DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            return View("getView", dept);
        }
        public RedirectResult gotoGoogle()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult gotoGoogle2()
        {
            return Redirect("~/new/getView8?id=1");
        }
        public RedirectResult gotoGoogle3()
        {
            return Redirect("~/new/gotoGoogle4?id=1&name=malesh");
        }
        public ViewResult gotoGoogle4(int id, string name)
        {
            return View();
        }

        public ActionResult GetmePartialView()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Balu";
            obj.EmpSalary = 3450000;


            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Mallesh";
            obj1.EmpSalary = 230000;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "jyothi";
            obj2.EmpSalary = 3250000;

            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            return View(listObj);
        }

        public PartialViewResult GetmePartialView2()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Balu";
            obj.EmpSalary = 3450000;


            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Mallesh";
            obj1.EmpSalary = 230000;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "jyothi";
            obj2.EmpSalary = 3250000;

            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            return PartialView("_mypartialView", listObj);
        }

        public FileResult GetFile()
        {
            return File("~/Web.config", "text/plain");
        }
        public FileResult GetFile2(int? id)
        {
            return File("~/Web.config", "application/pdf", "Web.config");
        }
        public FileResult GetFile3()
        {
            return File("~/ActionResult.pdf", "application/pdf");
        }
        public RedirectToRouteResult GoToMyActionMethods()
        {
            return RedirectToAction("GetFile");
        }
        public RedirectToRouteResult GoToMyActionMethods2()
        {
            return RedirectToAction("GetFile", "New");
        }

        public RedirectToRouteResult GoToMyActionMethods4()
        {
            return RedirectToAction("GetFile2", "New", new { id = 1 });
        }
        public RedirectToRouteResult GoToMyActionMethods5()
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Twinkle Twinkle Little Star";
            emp.EmpSalary = 10000;

            return RedirectToAction("TestMethod", "New", emp);
        }
        public ViewResult TestMethod(EmployeeModel emp)
        {
            return View();
        }

        public JsonResult SendjsonData()
        {

            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Balu";
            obj.EmpSalary = 3450000;


            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Mallesh";
            obj1.EmpSalary = 230000;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "jyothi";
            obj2.EmpSalary = 3250000;

            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            return Json(listObj, JsonRequestBehavior.AllowGet);

        }


        public JsonResult SendjsonData2()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Balu";
            obj.EmpSalary = 3450000;


            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Mallesh";
            obj1.EmpSalary = 230000;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "jyothi";
            obj2.EmpSalary = 3250000;

            List<EmployeeModel> listObj = new List<EmployeeModel>();
            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            return Json(listObj);

        }

        public ContentResult getMeContent(int? id)
        {

            if (id == 1)
            {
                return Content("Test Method");
            }
            else if (id == 2)
            {
                return Content("<p style=color:red>Test Method</p>");
            }
            else
            {
                return Content("<script>alert('Hello World')</script>");
            }
        }
        [CustomFilter]
        public ActionResult getFilterExample()
        {
            ViewBag.Player = "Dhoni";
            return View();

        }

        public ActionResult ValidationExample()
        {
            return View();
        }

    }
}