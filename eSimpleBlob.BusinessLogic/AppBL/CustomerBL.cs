using System;
using eSimpleBlob.BusinessLogic.AppCore;
using eSimpleBlob.BusinessLogic.Interfaces;
using eSimpleBlob.Domain.Entities.Customer;

namespace eSimpleBlob.BusinessLogic.AppBL
{
	public class CustomerBL : MainApi, ICustomer
	{
		public async Task<int> CreateCustomer(Customer customer)
		{
			return await CreateCustomerAction(customer);
		}

		public async Task<Customer?> GetCustomer(int customerId)
		{
			return await GetCustomerAction(customerId);
		}

		public async Task<int> UpdateCustomer(int customerId, Customer customer)
		{
			return await UpdateCustomerAction(customerId, customer);
		}
    }
}

