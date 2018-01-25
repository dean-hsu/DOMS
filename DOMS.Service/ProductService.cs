using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Interface.Service;
using DOMS.Model.DbModels;
using Microsoft.Extensions.Logging;

namespace DOMS.Service
{
    public class ProductService : IProductService
    {
        private readonly ILogger<OrderService> _logger;
        private readonly IProductRepository _productRepository;

        public ProductService(ILogger<OrderService> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        public IList<Product> GetProducts(string userName)
        {
            return _productRepository.GetProducts(userName);
        }
    }
}
