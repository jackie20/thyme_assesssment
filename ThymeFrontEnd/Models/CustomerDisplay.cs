using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThymeFrontEnd.Models
{
    public class CustomerDisplay
    {
        public int CustomerID { get; set; }
        public string CustomerDescription { get; set; }
        public string EmailAddress { get; set; }
        public string PartnerContact { get; set; }
        public string PartnerCustomerCode { get; set; }

        public DateTime DateCreated { get; set; }

        public int CountInvoices { get; set; }
    }
}
