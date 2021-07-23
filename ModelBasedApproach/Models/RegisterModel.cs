using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelBasedApproach.Models
{
    public class RegisterModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "UserName Cannot be Empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password and Confirm Password Not Matching")]
        [Required(ErrorMessage = "Confirm Password Cannot be Empty")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "EmailId Cannot be Empty")]
        [DataType(DataType.EmailAddress,ErrorMessage = "EmailId is Invalid Format")]
        public string EmailId { get; set; }

        [Range(10,40,ErrorMessage ="Age should be 10-40")]
        [ScaffoldColumn(false)]
        public int Age { get; set; }
        [StringLength(20,ErrorMessage ="max 20 character  is Accepted ")]
        public string Address { get; set; }
    }
}