using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOMS.Interface.Service;
using DOMS.Model.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DOMS.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        private readonly ICatalogueService _catalogueService;
        private readonly IFamilyService _familyService;
        private readonly IBrandService _brandService;

        public ProductController(ILogger<ProductController> logger, IProductService productService,
            IFamilyService familyService, ICatalogueService catalogueService, IBrandService brandService)
        {
            _logger = logger;
            _productService = productService;
            _familyService = familyService;
            _catalogueService = catalogueService;
            _brandService = brandService;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(_productService.GetProducts(User.Identity.Name));
        }

        public ActionResult Create()
        {
            ViewBag.FamilyList = _familyService.GetFamilies();
            ViewBag.CatalogueList = _catalogueService.GetCatalogues(ViewBag.FamilyList[0].FamilyId);
            ViewBag.BrandList = _brandService.GetBrands();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.FamilyList = _familyService.GetFamilies();
                ViewBag.CatalogueList = _catalogueService.GetCatalogues(ViewBag.FamilyList[0].FamilyId);
                ViewBag.BrandList = _brandService.GetBrands();
                return View();
            }
            product.CreatedUserName = User.Identity.Name;
            _productService.CreateProduct(product);
            return RedirectToAction("Index");
        }
    }
}