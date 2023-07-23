using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DATA.Models
{
    public class Categories
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Products> products { get; set; }
    }
}
