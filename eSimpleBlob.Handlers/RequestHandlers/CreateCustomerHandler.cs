using System;
using eSimpleBlob.BusinessLogic.Interfaces;
using eSimpleBlob.Handlers.Requests;
using MediatR;

namespace eSimpleBlob.Handlers.RequestHandlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, int>
    {
        //Inject Validators 
        private readonly ICustomer _customerRepository;

        public CreateCustomerHandler(ICustomer customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<int> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // First validate the request
            return await _customerRepository.CreateCustomer(request.Customer);
        }
    }
}

