using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Interface.Service;
using Microsoft.Extensions.Logging;

namespace DOMS.Service
{
    public class CatalogueService : ICatalogueService
    {
        private readonly ILogger<CatalogueService> _logger;
        private readonly ICatalogueRepository _catalogueRepository;

        public CatalogueService(ILogger<CatalogueService> logger, ICatalogueRepository catalogueRepository)
        {
            _logger = logger;
            _catalogueRepository = catalogueRepository;
        }
    }
}
