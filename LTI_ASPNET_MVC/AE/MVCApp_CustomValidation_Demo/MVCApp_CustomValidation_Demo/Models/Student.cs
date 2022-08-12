using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MVCApp_CustomValidation_Demo.CustomValidation;
namespace MVCApp_CustomValidation_Demo.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please choose admission date.")]
        [Display(Name = "Admission Date")]
        [DataType(DataType.Date)]
        [CustomAdmissionDate(ErrorMessage = "Admission Date must be less than or equal to Today's Date.")]
        public DateTime AdmissionDate { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Min18Years]
        public DateTime DateofBirth { get; set; }
    }
}
