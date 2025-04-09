using BankingAPI.Mediator.Queries.Customers;
using BankingAPI.Modules.Banking.BO.Dtos.Response;
using BankingAPI.Modules.Banking.Logic.Interfaces;
using MediatR;

namespace BankingAPI.Mediator.Handlers.Customers
{
    public class CustomerGetByIdHandler: IRequestHandler<CustomerGetByIdQuery, CustomerResponse>
    {
        protected readonly ICustomerService _customerService;

        public CustomerGetByIdHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<CustomerResponse> Handle(CustomerGetByIdQuery request, CancellationToken cancellationToken)
        {
            return await _customerService.GetById(request.id);
        }
    }
}
