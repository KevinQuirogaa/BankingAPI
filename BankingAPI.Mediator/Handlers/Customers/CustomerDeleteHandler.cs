using BankingAPI.Mediator.Commands.Customers;
using BankingAPI.Modules.Banking.Logic.Interfaces;
using MediatR;

namespace BankingAPI.Mediator.Handlers.Customers
{
    public class CustomerDeleteHandler: IRequestHandler<CustomerDeleteCommand, Unit>
    {
        protected readonly ICustomerService _customerService;

        public CustomerDeleteHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<Unit> Handle(CustomerDeleteCommand request, CancellationToken cancellationToken)
        {
            await _customerService.Delete(request.Id);
            return Unit.Value;
        }
    }
}
