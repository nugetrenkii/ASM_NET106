using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DATA.Models
{
    public class Cart
    {
        [Key]
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public Customers customers { get; set; }
        public virtual ICollection<CartDetails> cartDetails { get; set; }
    }
}
