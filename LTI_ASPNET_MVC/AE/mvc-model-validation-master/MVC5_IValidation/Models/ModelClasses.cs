using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC5_IValidation.Models
{
    public class Person : IValidatableObject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public int Income { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var pIncome = new[] { "Income" };
            if(Income<0)
            {
                yield return new ValidationResult("Income cannot be negative",pIncome);
            }
            var pName = new[] {"Name"};
            if (Name.Length > 40)
            {
                yield return new ValidationResult("Name cannot be greater than 40 characters",pName);
            }
            var pBDate = new[] {"BirthDate"};
            if (BirthDate > DateTime.Now)
            {
                yield return new ValidationResult("Sorry Future Date cannot be accepted.",pBDate);
            }
            
        }
    }
}
