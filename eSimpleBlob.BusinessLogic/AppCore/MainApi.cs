using System;
using eSimpleBlob.Domain.Entities.Customer;
using eSimpleBlob.Domain.Entities.Session;

namespace eSimpleBlob.BusinessLogic.AppCore
{
	public class MainApi
	{
		internal Task<int> CreateCustomerAction(Customer customer)
		{






			return Task.FromResult(1);
		}

		internal Task<Customer?> GetCustomerAction(int customerId)
		{




			var cc = new Customer {
				Address = "Test Address",
				EmailAddress = "test@test.com",
				FirstName = "Vasilica",
				LastName = "Careva"
			};




			return Task.FromResult<Customer?>(cc);
		}

		internal Task<int> UpdateCustomerAction(int customerId, Customer customer)
		{




			return Task.FromResult(1);
		}

		internal Task<TokenData?> CreateSessionAction(AuthData auth)
		{

			var session = new TokenData
			{
				Cookie = string.Empty,
				Token = string.Empty,
				ExpireTime = DateTime.Now.AddHours(2)
			};


			return Task.FromResult<TokenData?>(session);
		}

    }
}

