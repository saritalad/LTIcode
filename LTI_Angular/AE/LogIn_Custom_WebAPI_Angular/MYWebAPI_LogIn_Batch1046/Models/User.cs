using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MYWebAPI_LogIn_Batch1046.Models
{
    public class User
    {
        [Key]
        public Int64 UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
