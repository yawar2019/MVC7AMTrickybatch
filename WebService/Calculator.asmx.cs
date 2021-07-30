using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService.Model;
using Dapper;
namespace WebService
{
    /// <summary>
    /// Summary description for Calculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculator : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

       
        public string HelloWorld2()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int a,int b)
        {
            return a + b;

        }
        [WebMethod]
        public List<employeeDetail> GetEmployeeModels()
        {
            EmployeeEntities db = new EmployeeEntities();
            var data = db.spr_getEmployeeDetails1().ToList();
            return data;
        }
        //[WebMethod]
        //public IEnumerable<employeeDetail> GetEmployeeModels2()
        //{
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeEntities"].ToString());
        //    var data = con.Query<employeeDetail>("spr_getEmployeeDetails");
        //    return data;
        //}
    }
}
