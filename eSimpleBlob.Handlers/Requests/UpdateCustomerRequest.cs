using System;
using eSimpleBlob.Domain.Entities.Customer;
using MediatR;

namespace eSimpleBlob.Handlers.Requests
{
	public class UpdateCustomerRequest : IRequest<int>
    {

        public int customerId { get; set; }
        public Customer Customer { get; set; }
    }
}

