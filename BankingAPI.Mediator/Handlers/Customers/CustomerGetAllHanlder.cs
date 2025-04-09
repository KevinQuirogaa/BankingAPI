using BankingAPI.Mediator.Queries.Customers;
using BankingAPI.Modules.Banking.BO.Dtos.Response;
using BankingAPI.Modules.Banking.Logic.Interfaces;
using MediatR;

namespace BankingAPI.Mediator.Handlers.Customers
{
    public class CustomerGetAllHanlder: IRequestHandler<CustomerGetAllQuery, IEnumerable<CustomerResponse>>
    {
        protected readonly ICustomerService _customerService;

        public CustomerGetAllHanlder(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IEnumerable<CustomerResponse>> Handle(CustomerGetAllQuery request, CancellationToken cancellationToken)
        {
            return await _customerService.GetAll();
        }
    }
}
