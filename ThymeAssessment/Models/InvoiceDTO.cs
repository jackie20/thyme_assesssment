namespace ThymeAssessment.Models
{
    public class InvoiceDTO
    {

        public Invoice invoice { get; set; }
        public InvoiceDetail invoiceDetail { get; set; }
        public InvoiceHeader InvoiceHeader { get; set; }
    }
}
