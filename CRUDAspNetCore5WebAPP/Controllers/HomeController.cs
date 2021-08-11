using CRUD_BAL.Service;
using CRUD_DAL.Interface;
using CRUDAspNetCore5WebAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using CRUD_DAL.Entities;

namespace CRUDAspNetCore5WebAPP.Controllers
{
    public class HomeController : Controller
    {
        public ILogger<HomeController> Logger { get; }
        private readonly ManagerService _managerService;
        public IRepository<Manager> Manager { get; }

        public HomeController(IRepository<Manager> person, ManagerService productService, ILogger<HomeController> logger)
        {
            _managerService = productService;
            Manager = person;
            Logger = logger;

        }

        public async Task<IActionResult> Index()
        {
            var person = await _managerService.GetAllAsync();

            return View(person);
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
