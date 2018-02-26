using System;
using System.Collections.Generic;
using System.Linq;
using DOMS.Interface.Repository;
using DOMS.Model.DbModels;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext db) : base(db)
        {
        }

        public IList<Customer> GetCustomers(string userName)
        {
            return _db.Customers.Where(x => !x.Deleted && string.Equals(userName, x.UserName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public bool CreateCustomer(Customer customer)
        {
            AddCreateTime(customer);
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return true;
        }
    }
}
