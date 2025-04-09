using BankingAPI.Mediator.Commands.Customers;
using BankingAPI.Modules.Banking.BO.Dtos.Response;
using BankingAPI.Modules.Banking.Logic.Interfaces;
using MediatR;

namespace BankingAPI.Mediator.Handlers.Customers
{
    public  class CustomerCreateHandler: IRequestHandler<CustomerCreateCommand, CustomerResponse>
    {
        protected readonly ICustomerService _customerService;

        public CustomerCreateHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<CustomerResponse> Handle(CustomerCreateCommand request, CancellationToken cancellationToken)
        {
            return await _customerService.Create(request.CustomerRequest);
        }
    }
}
