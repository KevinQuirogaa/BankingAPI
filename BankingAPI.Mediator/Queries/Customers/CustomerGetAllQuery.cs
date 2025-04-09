using BankingAPI.Modules.Banking.BO.Dtos.Response;
using MediatR;

namespace BankingAPI.Mediator.Queries.Customers
{
    public record CustomerGetAllQuery() : IRequest<IEnumerable<CustomerResponse>>;
}
