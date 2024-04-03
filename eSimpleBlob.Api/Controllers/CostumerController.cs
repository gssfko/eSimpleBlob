using eSimpleBlob.Domain.Entities.Customer;
using eSimpleBlob.Handlers.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eSimpleBlob.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CostumerController : Controller
    {
        private readonly IMediator _mediator;

        public CostumerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("customerId")]
        public async Task<Customer?> GetCustomerAsync(int customerId)
        {
            var customerDetails = await _mediator.Send(new GetCustomerRequest() { CustomerId = customerId });

            return customerDetails;
        }

        [HttpPost]
        public async Task<int> CreateCustomerAsync(Customer customer)
        {
            var customerId = await _mediator.Send(new CreateCustomerRequest() { Customer = customer });
            return customerId;
        }

        [HttpPost("customerId")]
        public async Task<int> UpdateCustomerAsync(int customerId, Customer customer)
        {
            var result = await _mediator.Send(new UpdateCustomerRequest() { customerId = customerId, Customer = customer });
            return result;
        }
    }
}

