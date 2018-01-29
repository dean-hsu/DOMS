using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Interface.Service;
using DOMS.Model.DbModels;
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

        public IList<Catalogue> GetCatalogues()
        {
            return _catalogueRepository.GetCatalogues();
        }

        public bool AddCatalogue(Catalogue catalogue)
        {
            return _catalogueRepository.CreateCatalogue(catalogue);
        }
    }
}
