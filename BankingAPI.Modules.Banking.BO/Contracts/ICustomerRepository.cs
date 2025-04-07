using BankingAPI.Modules.Banking.BO.Models;

namespace BankingAPI.Modules.Banking.BO.Contracts
{
    public interface ICustomerRepository
    {
        Task<CustomerModel> AddCustomer(CustomerModel customer);
        Task<IEnumerable<CustomerModel>> GetAllCustomer();
        Task<CustomerModel> GetCustomerById(int id);
        Task<CustomerModel> UpdateCustomer(CustomerModel customer);
        Task DeleteCustomer (CustomerModel customer);
    }
}
