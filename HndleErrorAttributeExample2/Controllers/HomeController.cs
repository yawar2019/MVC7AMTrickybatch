using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HndleErrorAttributeExample2.Controllers
{
  

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            try
            {
                int a = 10, b = 0;
                int c = a / b;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HandleError(ExceptionType=typeof(DivideByZeroException),View ="dividedByZeroErrorView")]
        [HandleError(ExceptionType=typeof(FormatException),View ="FormatExceptionErrorView")]
        public ActionResult GetResult(string b)
        {
            try
            {
                int a = 10;
                int c = a / Convert.ToInt32(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View();
        }
        //Cache Filter Example
        [OutputCache]
        public ActionResult GetMeCatche()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}