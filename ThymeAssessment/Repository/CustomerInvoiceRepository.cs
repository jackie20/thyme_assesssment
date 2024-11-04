using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ThymeAssessment.Models;
using ThymeAssessment.Repository.Interfaces;

namespace ThymeAssessment.Repository
{
    public class CustomerInvoiceRepository : ICustomerInvoiceRepository
    {
        private readonly CustomerInvoiceDbContext _context;

        public CustomerInvoiceRepository(CustomerInvoiceDbContext context)
        {
            _context = context;
        }

        
        public async Task<ResponseModel> GetCustomerInvoices(int customerId)
        {
            var response = new ResponseModel();
            try
            {
                
                var invoices = await (from ih in _context.InvoiceHeaders
                                      join id in _context.InvoiceDetails on ih.InvoiceNumber equals id.InvoiceID.ToString()
                                      join inv in _context.Invoices on ih.InvoiceNumber equals inv.InvoiceNumber.ToString()
                                      where ih.CustomerID == customerId
                                      select new InvoiceDTO
                                      {
                                          InvoiceHeader = ih,
                                          invoiceDetail = id,
                                          invoice = inv
                                      }).ToListAsync();

                
                response.Success = true;
                response.Message = "Customer invoices retrieved successfully.";
                response.Data = new List<object>(invoices); 
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Error retrieving invoices: {ex.Message}";
                response.Data = null;
            }
            return response;
        }

        private void ValidateInvoice(InvoiceDTO invoiceDTO)
        {
            if (invoiceDTO == null)
                throw new ArgumentNullException(nameof(invoiceDTO), "Invoice data cannot be null.");

            // Validate InvoiceHeader
            if (invoiceDTO.InvoiceHeader == null)
                throw new ArgumentException("Invoice header is required.");

            if (string.IsNullOrWhiteSpace(invoiceDTO.InvoiceHeader.CustomerName))
                throw new ArgumentException("Customer name is required in the invoice header.");

            if (string.IsNullOrWhiteSpace(invoiceDTO.InvoiceHeader.CustomerAddress))
                throw new ArgumentException("Customer address is required in the invoice header.");

            if (string.IsNullOrWhiteSpace(invoiceDTO.InvoiceHeader.CustomerTelephone) || invoiceDTO.InvoiceHeader.CustomerTelephone.Length > 15)
                throw new ArgumentException("Customer telephone is required and must not exceed 15 characters.");

            // Validate InvoiceDetail
            if (invoiceDTO.invoiceDetail == null)
                throw new ArgumentException("Invoice detail is required.");

            if (string.IsNullOrWhiteSpace(invoiceDTO.invoiceDetail.ItemDescription))
                throw new ArgumentException("Item description in the invoice detail is required.");

            if (invoiceDTO.invoiceDetail.Quantity <= 0)
                throw new ArgumentException("Quantity must be greater than 0.");

            if (invoiceDTO.invoiceDetail.UnitPrice <= 0)
                throw new ArgumentException("Unit price must be greater than 0.");

            // Validate Invoice (main)
            if (invoiceDTO.invoice == null)
                throw new ArgumentException("Invoice information is required.");

            if (string.IsNullOrWhiteSpace(invoiceDTO.invoice.CustomerName))
                throw new ArgumentException("Customer name in the invoice is required.");

            if (!IsValidEmail(invoiceDTO.invoice.CustomerName))
                throw new ArgumentException("A valid email address is required in the invoice.");

            if (string.IsNullOrWhiteSpace(invoiceDTO.invoice.CustomerAddress))
                throw new ArgumentException("Customer address in the invoice is required.");

            // Additional checks as needed for any other properties in InvoiceDTO
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public async Task<ResponseModel> UpdateCustomerInvoice(InvoiceDTO invoiceDTO)
        {
            var response = new ResponseModel();
            try
            {
                if (invoiceDTO.InvoiceHeader.CustomerID <= 0)
                    throw new ArgumentException("Invalid customer ID.");

                ValidateInvoice(invoiceDTO);

                var existingCustomerInvoiceHeader = await _context.InvoiceHeaders.FindAsync(invoiceDTO.InvoiceHeader.InvoiceID);
                if (existingCustomerInvoiceHeader == null)
                    throw new KeyNotFoundException("Invoice Header not found.");

                existingCustomerInvoiceHeader.InvoiceNumber = invoiceDTO.InvoiceHeader.InvoiceNumber; 
                existingCustomerInvoiceHeader.CustomerID = invoiceDTO.InvoiceHeader.CustomerID;
                existingCustomerInvoiceHeader.CustomerName = invoiceDTO.InvoiceHeader.CustomerName;
                existingCustomerInvoiceHeader.CustomerAddress = invoiceDTO.InvoiceHeader.CustomerAddress;
                existingCustomerInvoiceHeader.CustomerTelephone = invoiceDTO.InvoiceHeader.CustomerTelephone; 

                _context.InvoiceHeaders.Update(existingCustomerInvoiceHeader);
                await _context.SaveChangesAsync();


                var existingCustomerInvoiceDetails = await _context.InvoiceDetails.FindAsync(invoiceDTO.invoiceDetail.DetailID);
                if (existingCustomerInvoiceDetails == null)
                    throw new KeyNotFoundException("Invoice Details not found.");

                existingCustomerInvoiceDetails.InvoiceID = invoiceDTO.invoiceDetail.InvoiceID;
                existingCustomerInvoiceDetails.ItemDescription = invoiceDTO.invoiceDetail.ItemDescription;
                existingCustomerInvoiceDetails.Quantity = invoiceDTO.invoiceDetail.Quantity;
                existingCustomerInvoiceDetails.UnitPrice = invoiceDTO.invoiceDetail.UnitPrice;
                existingCustomerInvoiceDetails.LineTotal = invoiceDTO.invoiceDetail.LineTotal;

                _context.InvoiceDetails.Update(existingCustomerInvoiceDetails);
                await _context.SaveChangesAsync();


                var existingCustomerInvoice = await _context.Invoices.FindAsync(invoiceDTO.invoice.InvoiceNumber);
                if (existingCustomerInvoice == null)
                    throw new KeyNotFoundException("Invoice not found.");

                existingCustomerInvoice.InvoiceDate = invoiceDTO.invoice.InvoiceDate;
                existingCustomerInvoice.CustomerAddress = invoiceDTO.invoice.CustomerAddress;
                existingCustomerInvoice.CustomerName = invoiceDTO.invoice.CustomerName;
                existingCustomerInvoice.CustomerTelephoneNumber = invoiceDTO.invoice.CustomerTelephoneNumber; 

                _context.Invoices.Update(existingCustomerInvoice);
                await _context.SaveChangesAsync();

                 

                response.Success = true;
                response.Message = "Customer Invoice updated successfully.";
                response.Data = new List<object> { existingCustomerInvoiceHeader };
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Error updating customer: {ex.Message}";
                response.Data = null;
            }
            return response;
        }

        public async Task<ResponseModel> DeleteCustomerInvoice(InvoiceDTO invoiceDTO)
        {

            var response = new ResponseModel();
            try
            {
                if (invoiceDTO.InvoiceHeader.InvoiceID <= 0)
                    throw new ArgumentException("Customer ID must be greater than zero.");

                var header = await _context.InvoiceHeaders.FindAsync(invoiceDTO.InvoiceHeader.InvoiceID);
                if (header == null)
                    throw new KeyNotFoundException("Invoice Header not found.");

                _context.InvoiceHeaders.Remove(header);
                await _context.SaveChangesAsync();

                var invoiceDetails = await _context.InvoiceDetails.FindAsync(invoiceDTO.invoiceDetail.DetailID); 
                _context.InvoiceDetails.Remove(invoiceDetails);
                await _context.SaveChangesAsync();

                var invoice = await _context.Invoices.FindAsync(invoiceDTO.invoice.InvoiceNumber);

                _context.Invoices.Remove(invoice);
                await _context.SaveChangesAsync();




                response.Success = true;
                response.Message = "Invoice deleted successfully.";
                response.Data = null;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Error deleting Invoice: {ex.Message}";
                response.Data = null;
            }

            return response;
        }
        public async Task<ResponseModel> AddCustomerInvoice(InvoiceDTO invoiceDTO)
        {

            var response = new ResponseModel();
            try
            {
                ValidateInvoice(invoiceDTO);

                await _context.Invoices.AddAsync(invoiceDTO.invoice);
                await _context.SaveChangesAsync();

                await _context.InvoiceHeaders.AddAsync(invoiceDTO.InvoiceHeader);
                await _context.SaveChangesAsync();


                await _context.InvoiceDetails.AddAsync(invoiceDTO.invoiceDetail);
                await _context.SaveChangesAsync();

                response.Success = true;
                response.Message = "Customer Invoice added successfully.";
                response.Data = new List<object> { invoiceDTO };
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Error adding customer: {ex.Message}";
                response.Data = null;
            }
            return response;
        }

   

    }
}
