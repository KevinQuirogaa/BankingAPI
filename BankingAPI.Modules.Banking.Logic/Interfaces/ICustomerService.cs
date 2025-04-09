using BankingAPI.Modules.Banking.BO.Dtos.Request;
using BankingAPI.Modules.Banking.BO.Dtos.Response;

namespace BankingAPI.Modules.Banking.Logic.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerResponse> Create(CustomerRequest customerRequest);
        Task<IEnumerable<CustomerResponse>> GetAll();
        Task<CustomerResponse> GetById(int id);
        Task<CustomerResponse> Update(int id, CustomerRequest customerRequest);
        Task Delete(int id);
    }
}
