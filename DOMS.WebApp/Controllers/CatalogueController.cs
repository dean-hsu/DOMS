using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOMS.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DOMS.WebApp.Controllers
{
    public class CatalogueController : Controller
    {
        private readonly ILogger<CatalogueController> _logger;
        private readonly ICatalogueService _catalogueService;

        public CatalogueController(ILogger<CatalogueController> logger, ICatalogueService catalogueService)
        {
            _logger = logger;
            _catalogueService = catalogueService;
        }

        public JsonResult GetCatalogues(int familyId)
        {
            var catalogues = _catalogueService.GetCatalogues(familyId);
            return Json(catalogues.Select(x => new {x.CatalogueId,x.Name}));
        }
    }
}