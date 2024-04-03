using System;
using eSimpleBlob.BusinessLogic.Interfaces;
using eSimpleBlob.Handlers.Requests;
using MediatR;

namespace eSimpleBlob.Handlers.RequestHandlers
{
	public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerRequest, int>
    {
        //Inject Validators 
        private readonly ICustomer _customerRepository;

        public UpdateCustomerHandler(ICustomer customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<int> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            // First validate the request
            return await _customerRepository.UpdateCustomer(request.customerId, request.Customer);
        }
    }
}

