using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DATA.Models
{
    public class Customers
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Sex { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}
