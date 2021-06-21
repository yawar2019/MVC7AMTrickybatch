using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC7AMTrickybatch.Models
{
    public class DepartmentModel
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }


    public class EmployeeandDepartments
    {
        public List<EmployeeModel> Emp { get; set; }
        public List<DepartmentModel> Dept { get; set; }
    }

}