using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DATA.Models
{
    public class Products
    {
        [Key]
        public Guid ID { get; set; }
        public Guid CategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal ImportPrice { get; set; }
        public string ImageLink { get; set; }
        public string QRCode { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
    }
}
