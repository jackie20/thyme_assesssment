using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThymeFrontEnd.Models
{
    public class InvoiceDTO
    {

        public Invoice invoice { get; set; }
        public InvoiceDetail invoiceDetail { get; set; }
        public InvoiceHeader InvoiceHeader { get; set; }
    }
}
