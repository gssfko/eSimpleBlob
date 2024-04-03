using System;
using eSimpleBlob.Domain.Entities.Customer;

namespace eSimpleBlob.BusinessLogic.Interfaces
{
    public interface ICustomer
    {
        Task<int> CreateCustomer(Customer customer);
        Task<Customer?> GetCustomer(int customerId);
        Task<int> UpdateCustomer(int customerId, Customer customer);
    }
}

