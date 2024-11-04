using ThymeAssessment.Models;
using ThymeAssessment.Repository.Interfaces;
using ThymeAssessment.Service.Interaces;

namespace ThymeAssessment.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<ResponseModel> GetAllCustomersAsync()
        {
            try
            {
                var response = await _customerRepository.GetAllCustomersAsync();
                return response;
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = $"Error retrieving customers: {ex.Message}",
                    Data = null
                };
            }
        }

        public async Task<ResponseModel> GetCustomerByIdAsync(int id)
        {
            try
            {
                return await _customerRepository.GetCustomerByIdAsync(id);
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = $"Error retrieving customer: {ex.Message}",
                    Data = null
                };
            }
        }

        public async Task<ResponseModel> AddCustomerAsync(Customer customer)
        {
            try
            {
                return await _customerRepository.AddCustomerAsync(customer);
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = $"Error adding customer: {ex.Message}",
                    Data = null
                };
            }
        }

        public async Task<ResponseModel> UpdateCustomerAsync(Customer customer)
        {
            try
            {
                return await _customerRepository.UpdateCustomerAsync(customer);
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = $"Error updating customer: {ex.Message}",
                    Data = null
                };
            }
        }

        public async Task<ResponseModel> DeleteCustomerAsync(int id)
        {
            try
            {
                return await _customerRepository.DeleteCustomerAsync(id);
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Success = false,
                    Message = $"Error deleting customer: {ex.Message}",
                    Data = null
                };
            }
        }
    }
}
