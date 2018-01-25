using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Service;
using Microsoft.Extensions.Logging;
using DOMS.Interface.Repository;

namespace DOMS.Service
{
    public class CourierService : ICourierService
    {
        private readonly ILogger<CourierService> _logger;
        private readonly ICourierRepository _courierRepository;

        public CourierService(ILogger<CourierService> logger, ICourierRepository courierRepository)
        {
            _logger = logger;
            _courierRepository = courierRepository;
        }
    }
}
