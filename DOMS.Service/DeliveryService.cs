using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Interface.Service;
using Microsoft.Extensions.Logging;

namespace DOMS.Service
{
    public class DeliveryService : IDeliveryService
    {
        private readonly ILogger<DeliveryService> _logger;
        private readonly IDeliveryRepository _deliveryRepository;

        public DeliveryService(ILogger<DeliveryService> logger, IDeliveryRepository deliveryRepository)
        {
            _logger = logger;
            _deliveryRepository = deliveryRepository;
        }
    }
}
