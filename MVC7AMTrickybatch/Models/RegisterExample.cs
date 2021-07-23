using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC7AMTrickybatch.Models
{
    public class RegisterExample
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage ="EmpName Cannot be Empty")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "EmpName Cannot be Empty")]
        public string Password { get; set; }
        [Required(ErrorMessage = "EmpName Cannot be Empty")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "EmpName Cannot be Empty")]

        public string EmailId { get; set; }
        [Required(ErrorMessage = "EmpName Cannot be Empty")]

        public string Address { get; set; }
        [Required(ErrorMessage = "EmpName Cannot be Empty")]

        public int age { get; set; }
    }
}