using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DATA.Models
{
    public class Bills
    {
        [Key]
        public Guid ID { get; set; }
        public string BillCode { get; set; }
        public Guid CustomerID { get; set; }
        public Guid StaffID { get; set; }
        public DateTime DateCreate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<BillDetails> billDetails { get; set; }
    }
}
