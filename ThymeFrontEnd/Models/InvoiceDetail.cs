using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThymeFrontEnd.Models
{
    public class InvoiceDetail
    {
        [Key]
        public int DetailID { get; set; }
        public int InvoiceID { get; set; }
        public string ItemDescription { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }


    }
}
