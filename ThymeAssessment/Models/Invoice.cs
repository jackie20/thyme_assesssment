using System.ComponentModel.DataAnnotations;

namespace ThymeAssessment.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceNumber { get; set; }  
        public DateTime InvoiceDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerTelephoneNumber { get; set; }
         
    }
}
