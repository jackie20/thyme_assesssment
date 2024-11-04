using ThymeAssessment.Models;

namespace ThymeAssessment.Service.Interaces
{
    public interface ICustomerInvoiceService
    {
        Task<ResponseModel> GetCustomerInvoices(int customerId);
        Task<ResponseModel> AddCustomerInvoice(InvoiceDTO invoiceDTO);
        Task<ResponseModel> UpdateCustomerInvoice(InvoiceDTO invoiceDTO);
        Task<ResponseModel> DeleteCustomerInvoice(InvoiceDTO invoiceDTO);
    }
}
