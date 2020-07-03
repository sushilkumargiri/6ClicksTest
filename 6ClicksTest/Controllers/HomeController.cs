using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _6ClicksTest.Models;
using _6ClicksTest.Services;
using _6ClicksTest.ViewModel;

namespace _6ClicksTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //input 1
            //var receipt = new GoodsService().GetReceipt(InputData.GetGoodsInput());
            //input 2
            var receipt = new GoodsService().GetReceipt(InputData.GetImportedGoodsInput());
            ViewBag.Receipt = receipt;

            return View();
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
