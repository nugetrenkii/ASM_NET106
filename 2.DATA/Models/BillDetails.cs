using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DATA.Models
{
    public class BillDetails
    {
        [Key]
        public Guid ID { get; set; }
        public Guid BillID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }

        public Bills bills { get; set; }
        public Products products { get; set; }
    }
}
