using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoMapperExample.Models;
using AM.infrastructure.Service.ProductBsl;

namespace AutoMapperExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductBsl productBsl;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProductBsl productBsl)
        {
            _logger = logger;
            this.productBsl = productBsl;
        }

        public IActionResult Index()
        {
            var lstPreoduct = productBsl.TestPerformance();


            return View(lstPreoduct);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
