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
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=MaleshLokeshDb;Integrated Security=true");

        public List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            SqlCommand cmd = new SqlCommand("usp_getEmployees", con);
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

        public int SaveEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = null;
            if (emp.EmpId==0)
            {
                cmd = new SqlCommand("usp_CreateEmployee", con);
                
            }
            else
            {
                cmd = new SqlCommand("usp_UpdateEmployee", con);
                cmd.Parameters.AddWithValue("@EmpId", emp.EmpId);

            }
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public EmployeeModel GetEmployeeById(int? id)
        {
            EmployeeModel emp = new EmployeeModel();

            SqlCommand cmd = new SqlCommand("usp_getEmployeebyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpId", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);

            }
            return emp;
        }
    }
}