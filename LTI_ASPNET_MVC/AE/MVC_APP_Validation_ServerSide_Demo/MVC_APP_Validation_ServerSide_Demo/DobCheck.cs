using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_APP_Validation_ServerSide_Demo
{
    public class DobCheck : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime birthdate = Convert.ToDateTime(value);
            int birthyear = birthdate.Year;
            int todayyear = DateTime.Now.Year;
            if (todayyear - birthyear >= 21)
                return true;
            else return false;
        }
    }
}
