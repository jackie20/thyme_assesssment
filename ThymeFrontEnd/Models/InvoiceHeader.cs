using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThymeFrontEnd.Models
{
    public class InvoiceHeader
    {
        [Key]
        public int InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerTelephone { get; set; }
    }
}
