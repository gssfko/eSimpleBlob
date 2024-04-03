using System;
using eSimpleBlob.BusinessLogic.Interfaces;
using eSimpleBlob.Domain.Entities.Customer;
using eSimpleBlob.Handlers.Requests;
using MediatR;

namespace eSimpleBlob.Handlers.RequestHandlers
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerRequest, Customer?>
    {
        private readonly ICustomer _customerRepository;

        public GetCustomerHandler(ICustomer customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer?> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            return await _customerRepository.GetCustomer(request.CustomerId);
        }
    }
}

