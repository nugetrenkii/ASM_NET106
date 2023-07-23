using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DATA.Models
{
    public class Bills
    {
        public Guid ID { get; set; }
        public string BillCode { get; set; }
        public Guid CustomerID { get; set; }
        public Guid StaffID { get; set; }
        public DateTime DateCreate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }
}
