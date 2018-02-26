using DOMS.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DOMS.WebApp.Controllers
{
    public class BrandController : Controller
    {
        private readonly ILogger _logger;
        private readonly IBrandService _brandService;

        public BrandController(ILogger logger, IBrandService brandService)
        {
            _logger = logger;
            brandService = _brandService;
        }

        public IActionResult Index()
        {
            return View(_brandService.GetBrands());
        }
    }
}