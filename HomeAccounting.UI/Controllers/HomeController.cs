using HomeAccounting.BusinessLogic.Contract.Interfaces;
using HomeAccounting.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace HomeAccounting.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccounting _accountingService;

        public HomeController(
            ILogger<HomeController> logger,
            IAccounting accountingService
            )
        {
            _logger = logger;
            _accountingService = accountingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CerateAccount()
        {
            _accountingService.CreateAccount(new BusinessLogic.Contract.Entity.Account
            {
                CreationDate = DateTime.Now,
                Name = "Y\"O"
            });

            return Json(new { Status = true });
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
