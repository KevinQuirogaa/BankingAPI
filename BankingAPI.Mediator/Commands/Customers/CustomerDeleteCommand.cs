using MediatR;

namespace BankingAPI.Mediator.Commands.Customers
{
    public record CustomerDeleteCommand(int Id) : IRequest<Unit>;
}
