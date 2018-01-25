using DOMS.Interface.Service;
using System;
using DOMS.Model.DbModels;
using System.Collections.Generic;
using DOMS.Interface.Repository;
using Microsoft.Extensions.Logging;

namespace DOMS.Service
{
    public class OrderService : IOrderService
    {
        private readonly ILogger<OrderService> _logger;
        private readonly IOrderRepository _orderRepository;

        public OrderService(ILogger<OrderService> logger, IOrderRepository orderRepository)
        {
            _logger = logger;
            _orderRepository = orderRepository;
        }

        public IList<Order> GetOrders(string userName)
        {
            return _orderRepository.GetOrders(userName);
        }
    }
}
