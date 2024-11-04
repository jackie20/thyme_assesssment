using ThymeAssessment.Models;

namespace ThymeAssessment.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        Task<ResponseModel> GetAllCustomersAsync();
        Task<ResponseModel> GetCustomerByIdAsync(int id);
        Task<ResponseModel> AddCustomerAsync(Customer customer);
        Task<ResponseModel> UpdateCustomerAsync(Customer customer);
        Task<ResponseModel> DeleteCustomerAsync(int id);
    }
}
