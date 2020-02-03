using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyShop.Models.HomeViewModels;
using CandyShop.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandyService _candyService;

        public HomeController(ICandyService candyService)
        {
            _candyService = candyService;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                CandyOnSale = _candyService.GetCandiesOnSale
            };
            return View(model);
        }
    }
}