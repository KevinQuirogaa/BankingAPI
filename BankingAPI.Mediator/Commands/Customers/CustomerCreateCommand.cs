using BankingAPI.Modules.Banking.BO.Dtos.Request;
using BankingAPI.Modules.Banking.BO.Dtos.Response;
using MediatR;

namespace BankingAPI.Mediator.Commands.Customers
{
    public record CustomerCreateCommand(CustomerRequest CustomerRequest): IRequest<CustomerResponse>;
}
