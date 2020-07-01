using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Models
{
    public class Register
    {
        [Key]
        public string  StudentId { get; set; }
        public string Name { get; set; }
        
        public string Address { get; set; }
        public string Gender { get; set; }
        
        public string Birth_date { get; set; }

        public string Course { get; set; }
        public string Email { get; set; }
    }
}
