using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DATA.Models
{
    public class Staff
    {
        [Key]
        public Guid ID { get; set; }
        public Guid ReportID { get; set; }
        public Guid RoleID { get; set; }
        public string StaffName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string StaffImage { get; set; }
        public bool Sex { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}
