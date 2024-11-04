using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThymeAssessment.Models
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
