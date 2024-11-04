using System.ComponentModel.DataAnnotations;

namespace ThymeAssessment.Models
{
    public class Customer
    {

        [Key]
        public int CustomerID { get; set; } 
        public string CustomerDescription { get; set; } 
        public string EmailAddress { get; set; }
         
        public string PartnerContact { get; set; } 
        public string PartnerCustomerCode { get; set; }
    }
}
