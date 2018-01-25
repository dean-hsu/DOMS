using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Interface.Service;
using DOMS.Model.DbModels;
using Microsoft.Extensions.Logging;

namespace DOMS.Service
{
    public class BrandService : IBrandService
    {
        private readonly ILogger<BrandService> _logger;
        private readonly IBrandRepository _brandRepository;

        public BrandService(ILogger<BrandService> logger, IBrandRepository brandRepository)
        {
            _logger = logger;
            _brandRepository = brandRepository;
        }

        public IList<Brand> GetBrands()
        {
            return _brandRepository.GetBrands();
        }

        public bool AddBrand(Brand brand)
        {
            return _brandRepository.CreateBrand(brand);
        }
    }
}
