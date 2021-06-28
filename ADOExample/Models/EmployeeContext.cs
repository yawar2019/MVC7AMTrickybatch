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
            SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=MaleshLokeshDb;Integrated Security=true");

        }
    }
}