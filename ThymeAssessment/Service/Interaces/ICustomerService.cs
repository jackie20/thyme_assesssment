using ThymeAssessment.Models;

namespace ThymeAssessment.Service.Interaces
{
    public interface ICustomerService
    {
        Task<ResponseModel> GetAllCustomersAsync();
        Task<ResponseModel> GetCustomerByIdAsync(int id);
        Task<ResponseModel> AddCustomerAsync(Customer customer);
        Task<ResponseModel> UpdateCustomerAsync(Customer customer);
        Task<ResponseModel> DeleteCustomerAsync(int id);
    }
}
