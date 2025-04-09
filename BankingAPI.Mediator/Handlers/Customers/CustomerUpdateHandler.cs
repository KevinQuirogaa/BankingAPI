using BankingAPI.Mediator.Commands.Customers;
using BankingAPI.Modules.Banking.BO.Dtos.Response;
using BankingAPI.Modules.Banking.Logic.Interfaces;
using MediatR;

namespace BankingAPI.Mediator.Handlers.Customers
{
    public class CustomerUpdateHandler: IRequestHandler<CustomerUpdateCommand, CustomerResponse>
    {
        protected readonly ICustomerService _customerService;

        public CustomerUpdateHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<CustomerResponse> Handle(CustomerUpdateCommand request, CancellationToken cancellationToken)
        {
            return await _customerService.Update(request.Id, request.CustomerRequest);
        }
    }
}
