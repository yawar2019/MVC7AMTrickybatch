using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ADOExample.Models
{
    public class EmployeeContext
    {
        public List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=MaleshLokeshDb;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("usp_getEmployees",con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
                listEmp.Add(emp);
            }
            return listEmp;
        }
    }
}