using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOMS.Interface.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DOMS.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(_productService.GetProducts(User.Identity.Name));
        }

        
    }
}