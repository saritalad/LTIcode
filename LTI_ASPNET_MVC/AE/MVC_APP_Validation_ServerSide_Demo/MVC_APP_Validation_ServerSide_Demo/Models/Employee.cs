using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_APP_Validation_ServerSide_Demo.Models
{
    public class Employee
    {
        [Display(Name = "Emp Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Compulsory")]
        public string Name { get; set; }
        [Range(10000, 90000, ErrorMessage = "Salary between 10000 and 90000")]
        public int? Salary { get; set; }
        [Display(Name = "Department")]
        public int? Deptid { get; set; }
        [Display(Name = "BirthDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DobCheck(ErrorMessage = "To Join Lnt You must be 21 years of Age")]
        public DateTime? Dob { get; set; }
        [DataType(DataType.EmailAddress)]
        [Remote("CheckEmail", "Emp", ErrorMessage = "Duplicate Email")]
        public string Email { get; set; }

        
    }
}
