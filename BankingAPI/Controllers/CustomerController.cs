using BankingAPI.Mediator.Commands.Customers;
using BankingAPI.Mediator.Queries.Customers;
using BankingAPI.Modules.Banking.BO.Dtos.Request;
using BankingAPI.Modules.Banking.BO.Dtos.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BankingAPI.Controllers
{
    [Route("customer")]
    [ApiController]
    [Produces("application/json")]
    public class CustomerController : Controller
    {
        protected readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Create(CustomerRequest customerRequest)
        {
            await _mediator.Send(new CustomerCreateCommand(customerRequest));
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<CustomerResponse>>> GetAll()
        {
            var customers = await _mediator.Send(new CustomerGetAllQuery());
            return Ok(customers);
        }

        [HttpGet("id")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CustomerResponse>> GetById(int id)
        {
            var customer = await _mediator.Send(new CustomerGetByIdQuery(id));
            return Ok(customer);
        }

        [HttpPut("id")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CustomerResponse>> Update(int id, CustomerRequest customerRequest)
        {
            var customer = await _mediator.Send(new CustomerUpdateCommand(id, customerRequest));
            return Ok(customer);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new CustomerDeleteCommand(id));
            return NoContent();
        }
    }
}
