using System;
using eSimpleBlob.BusinessLogic.AppBL;
using eSimpleBlob.BusinessLogic.Interfaces;

namespace eSimpleBlob.BusinessLogic
{
	public class BusinessLogic
	{ 
		public ICustomer GetCustomerBL()
		{
			return new CustomerBL();
		}
	}
}

