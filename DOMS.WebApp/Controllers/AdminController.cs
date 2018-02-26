using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DOMS.Interface.Service;
using DOMS.Model.DbModels;
using DOMS.WebApp.Helper;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IHostingEnvironment _appEnvironment;

        public AdminController(ILogger<AdminController> logger, IBrandService brandService,
            ICountryService countryService, IFamilyService familyService, ICatalogueService catalogueService,
            IHostingEnvironment appEnvironment)
        {
            _logger = logger;
            _brandService = brandService;
            _countryService = countryService;
            _familyService = familyService;
            _catalogueService = catalogueService;
            _appEnvironment = appEnvironment;
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBrand(Brand brand)
        {
            ViewBag.CountryList = _countryService.GetCountries().OrderBy(x => x.CountryName);
            if (!ModelState.IsValid)
            {
                return View();
            }

            var files = HttpContext.Request.Form.Files;
            var imgFolder = Path.Combine(_appEnvironment.WebRootPath, "images\\upload\\logo");
            foreach (var image in files)
            {
                try
                {
                    brand.BrandLogo = await ImageUploader.UploadImage(image, imgFolder).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("BrandLogo", ex.Message);
                    return View();
                }
            }

            _brandService.AddBrand(brand);
            
            return RedirectToAction("Brands");
        }

        public IActionResult EditBrand(int id)
        {
            ViewBag.CountryList = _countryService.GetCountries().OrderBy(x => x.CountryName);
            return View(_brandService.GetBrand(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBrand(Brand brand)
        {
            ViewBag.CountryList = _countryService.GetCountries().OrderBy(x => x.CountryName);
            if (!ModelState.IsValid)
            {
                return View();
            }

            var files = HttpContext.Request.Form.Files;
            var imgFolder = Path.Combine(_appEnvironment.WebRootPath, "images\\upload\\logo");
            foreach (var image in files)
            {
                try
                {
                    brand.BrandLogo = await ImageUploader.UploadImage(image, imgFolder).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("BrandLogo", ex.Message);
                    return View();
                }
            }

            _brandService.UpdateBrand(brand);

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
        [ValidateAntiForgeryToken]
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
        [ValidateAntiForgeryToken]
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