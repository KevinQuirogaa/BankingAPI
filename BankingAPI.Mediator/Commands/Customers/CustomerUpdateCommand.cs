using BankingAPI.Modules.Banking.BO.Dtos.Request;
using BankingAPI.Modules.Banking.BO.Dtos.Response;
using MediatR;

namespace BankingAPI.Mediator.Commands.Customers
{
    public record CustomerUpdateCommand(int Id, CustomerRequest CustomerRequest) : IRequest<CustomerResponse>;
}
