using ThymeAssessment.Models;
using ThymeAssessment.Repository.Interfaces;
using ThymeAssessment.Service.Interaces;

namespace ThymeAssessment.Service
{
    public class CustomerInvoiceService : ICustomerInvoiceService
    {
        private readonly ICustomerInvoiceRepository _customerInvoiceRepository;
        public CustomerInvoiceService(ICustomerInvoiceRepository customerInvoiceRepository)
        {
            _customerInvoiceRepository = customerInvoiceRepository;
        }

        public async Task<ResponseModel> GetCustomerInvoices(int customerId)
        {
            try
            {
                var response = await _customerInvoiceRepository.GetCustomerInvoices(customerId);
                return response;
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = $"Error retrieving customer Invoices: {ex.Message}",
                    Data = null
                };
            }
        }

        public async Task<ResponseModel> AddCustomerInvoice(InvoiceDTO invoiceDTO)
        {
            try
            {
                var response = await _customerInvoiceRepository.AddCustomerInvoice(invoiceDTO);
                return response;
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = $"Error Adding customer Invoices: {ex.Message}",
                    Data = null
                };
            }
        }


        public async Task<ResponseModel> UpdateCustomerInvoice(InvoiceDTO invoiceDTO)
        {
            try
            {
                var response = await _customerInvoiceRepository.UpdateCustomerInvoice(invoiceDTO);
                return response;
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = $"Error Updating customer Invoices: {ex.Message}",
                    Data = null
                };
            }
        }


        public async Task<ResponseModel> DeleteCustomerInvoice(InvoiceDTO invoiceDTO)
        {
            try
            {
                var response = await _customerInvoiceRepository.DeleteCustomerInvoice(invoiceDTO);
                return response;
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = $"Error Deleting customer Invoices: {ex.Message}",
                    Data = null
                };
            }
        }



    }
}

 