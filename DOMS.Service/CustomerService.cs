using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Interface.Service;
using DOMS.Model.DbModels;
using Microsoft.Extensions.Logging;

namespace DOMS.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ILogger<CustomerService> _logger;
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ILogger<CustomerService> logger, ICustomerRepository customerRepository)
        {
            _logger = logger;
            _customerRepository = customerRepository;
        }

        public IList<Customer> GetCustomers(string userName)
        {
            return _customerRepository.GetCustomers(userName);
        }

        public bool AddCustomer(Customer customer)
        {
            return _customerRepository.CreateCustomer(customer);
        }
    }
}
