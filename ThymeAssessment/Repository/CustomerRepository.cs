using Microsoft.EntityFrameworkCore;
using ThymeAssessment.Models;
using ThymeAssessment.Repository.Interfaces;

namespace ThymeAssessment.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerInvoiceDbContext _context;

        public CustomerRepository(CustomerInvoiceDbContext context)
        {
            _context = context;
        }
       

        public async Task<ResponseModel> GetCustomerInvoices(int customerId)
        {
            var response = new ResponseModel();
            try
            {
                var customers = await _context.Customers.ToListAsync();
                response.Success = true;
                response.Message = "Customers Invoices successfully.";
                response.Data = new List<object>(customers);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Error retrieving Invoices: {ex.Message}";
                response.Data = null;
            }
            return response;
        }


        public async Task<ResponseModel> GetAllCustomersAsync()
        {
            var response = new ResponseModel();
            try
            {
                var customers = await _context.Customers.ToListAsync();
                response.Success = true;
                response.Message = "Customers retrieved successfully.";
                response.Data = new List<object>(customers);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Error retrieving customers: {ex.Message}";
                response.Data = null;
            }
            return response;
        }


        // Get a single customer by ID
        public async Task<ResponseModel> GetCustomerByIdAsync(int id)
        {
            var response = new ResponseModel();
            try
            {
                if (id <= 0)
                    throw new ArgumentException("Customer ID must be greater than zero.");

                var customer = await _context.Customers.FindAsync(id);
                if (customer == null)
                    throw new KeyNotFoundException("Customer not found.");

                response.Success = true;
                response.Message = "Customer retrieved successfully.";
                response.Data = new List<object> { customer };
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Error retrieving customer: {ex.Message}";
                response.Data = null;
            }
            return response;
        }


        public async Task<ResponseModel> AddCustomerAsync(Customer customer)
        {
            var response = new ResponseModel();
            try
            {
                ValidateCustomer(customer);

                await _context.Customers.AddAsync(customer);
                await _context.SaveChangesAsync();

                response.Success = true;
                response.Message = "Customer added successfully.";
                response.Data = new List<object> { customer };
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Error adding customer: {ex.Message}";
                response.Data = null;
            }
            return response;
        }

        // Update an existing customer
        public async Task<ResponseModel> UpdateCustomerAsync(Customer customer)
        {
            var response = new ResponseModel();
            try
            {
                if (customer.CustomerID <= 0)
                    throw new ArgumentException("Invalid customer ID.");

                ValidateCustomer(customer);

                var existingCustomer = await _context.Customers.FindAsync(customer.CustomerID);
                if (existingCustomer == null)
                    throw new KeyNotFoundException("Customer not found.");

                existingCustomer.CustomerDescription = customer.CustomerDescription;
                existingCustomer.EmailAddress = customer.EmailAddress;
                existingCustomer.PartnerContact = customer.PartnerContact;
                existingCustomer.PartnerCustomerCode = customer.PartnerCustomerCode;

                _context.Customers.Update(existingCustomer);
                await _context.SaveChangesAsync();

                response.Success = true;
                response.Message = "Customer updated successfully.";
                response.Data = new List<object> { existingCustomer };
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Error updating customer: {ex.Message}";
                response.Data = null;
            }
            return response;
        }

        // Delete a customer by ID
        public async Task<ResponseModel> DeleteCustomerAsync(int id)
        {
            var response = new ResponseModel();
            try
            {
                if (id <= 0)
                    throw new ArgumentException("Customer ID must be greater than zero.");

                var customer = await _context.Customers.FindAsync(id);
                if (customer == null)
                    throw new KeyNotFoundException("Customer not found.");

                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();

                response.Success = true;
                response.Message = "Customer deleted successfully.";
                response.Data = null;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Error deleting customer: {ex.Message}";
                response.Data = null;
            }
            return response;
        }

        // Validate customer data
        private void ValidateCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");

            if (string.IsNullOrWhiteSpace(customer.CustomerDescription))
                throw new ArgumentException("Customer description is required.");

            if (string.IsNullOrWhiteSpace(customer.EmailAddress) || !IsValidEmail(customer.EmailAddress))
                throw new ArgumentException("Valid email address is required.");

            if (string.IsNullOrWhiteSpace(customer.PartnerCustomerCode) || customer.PartnerCustomerCode.Length > 6)
                throw new ArgumentException("Partner customer code is required and must be a maximum of 6 characters.");
        }

        // Email validation helper
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
    }
}

