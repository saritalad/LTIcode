using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYMVC_TagHelper_Demo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Branch Branch { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public IEnumerable<Gender> AllGenders { set; get; }
    }


    public enum Branch
    {
        None,
        CSE,
        ETC,
        Mech
    }  // labeled integers

    public enum Gender
    {
       one,
       two,
       three,
       four
    }

}
