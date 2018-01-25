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

        public AdminController(ILogger<AdminController> logger, IBrandService brandService, ICountryService countryService)
        {
            _logger = logger;
            _brandService = brandService;
            _countryService = countryService;
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
    }
}