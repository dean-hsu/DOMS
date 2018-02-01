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

        public IActionResult CreateFamily()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFamily(Family family)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _familyService.AddFamily(family);

            return RedirectToAction("Families");
        }

        public IActionResult Catalogues()
        {
            return View(_catalogueService.GetCatalogues());
        }

        public IActionResult CreateCatalogue()
        {
            ViewBag.Families = _familyService.GetFamilies();
            return View();
        }

        [HttpPost]
        public IActionResult CreateCatalogue(Catalogue catalogue)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Families = _familyService.GetFamilies();
                return View();
            }

            _catalogueService.AddCatalogue(catalogue);

            return RedirectToAction("Catalogues");
        }
    }
}