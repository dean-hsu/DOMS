using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Repository
{
    public interface ICustomerRepository
    {
        IList<Customer> GetCustomers(string userName);
        bool CreateCustomer(Customer customer);
    }
}
