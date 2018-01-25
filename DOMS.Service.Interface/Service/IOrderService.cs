using DOMS.Model.DbModels;
using System;
using System.Collections.Generic;

namespace DOMS.Interface.Service
{
    public interface IOrderService
    {
        IList<Order> GetOrders(string userName);
    }
}
