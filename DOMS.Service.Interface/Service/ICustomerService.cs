using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Service
{
    public interface ICustomerService
    {
        IList<Customer> GetCustomers(string userName);
        bool AddCustomer(Customer customer);
    }
}
