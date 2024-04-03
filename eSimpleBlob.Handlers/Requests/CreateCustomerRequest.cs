using System;
using eSimpleBlob.Domain.Entities.Customer;
using MediatR;

namespace eSimpleBlob.Handlers.Requests
{
	public class CreateCustomerRequest : IRequest<int>
	{
		public Customer Customer { get; set; }
	}
}

