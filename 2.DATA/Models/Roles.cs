using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DATA.Models
{
    public class Roles
    {
        [Key]
        public Guid ID { get; set; }
        public string RoleName { get; set; }        
    }
}
