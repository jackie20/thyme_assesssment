using ThymeAssessment.Models;

namespace ThymeAssessment.Repository.Interfaces
{
    public interface ICustomerInvoiceRepository
    {
   
        Task<ResponseModel> GetCustomerInvoices(int customerId);
        Task<ResponseModel> AddCustomerInvoice(InvoiceDTO invoiceDTO);
        Task<ResponseModel> UpdateCustomerInvoice(InvoiceDTO invoiceDTO);
        Task<ResponseModel> DeleteCustomerInvoice(InvoiceDTO invoiceDTO);


    }
}
