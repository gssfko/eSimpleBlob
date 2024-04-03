using System;
using eSimpleBlob.Domain.Entities.Customer;
using MediatR;

namespace eSimpleBlob.Handlers.Requests
{
    public class GetCustomerRequest : IRequest<Customer?>
    {
        public int CustomerId { get; set; }
    }
}

