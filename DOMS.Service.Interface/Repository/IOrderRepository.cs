using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Model.DbModels;

namespace DOMS.Interface.Repository
{
    public interface IOrderRepository
    {
        IList<Order> GetOrders(string userName);
    }
}
