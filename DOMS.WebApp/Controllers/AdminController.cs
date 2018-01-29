using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOMS.Interface.Service;
using DOMS.Model.DbModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DOMS.WebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IBrandService _brandService;
        private readonly ICountryService _countryService;
        private readonly IFamilyService _familyService;
        private readonly ICatalogueService _catalogueService;

        public AdminController(ILogger<AdminController> logger, IBrandService brandService, ICountryService countryService, IFamilyService familyService, ICatalogueService catalogueService)
        {
            _logger = logger;
            _brandService = brandService;
            _countryService = countryService;
            _familyService = familyService;
            _catalogueService = catalogueService;
        }

        public IActionResult Brands()
        {
            return View(_brandService.GetBrands());
        }

        public IActionResult AddBrand()
        {
            ViewBag.CountryList = _countryService.GetCountries().OrderBy(x=>x.CountryName);
            return View();
        }

        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            ViewBag.CountryList = _countryService.GetCountries().OrderBy(x => x.CountryName);
            if (!ModelState.IsValid)
            {
                return View();
            }

            _brandService.AddBrand(brand);
            
            return RedirectToAction("Brands");
        }

        public IActionResult Families()
        {
            return View(_familyService.GetFamilies());
        }

        public IActionResult Catalogues()
        {
            return View(_catalogueService.GetCatalogues());
        }
    }
}