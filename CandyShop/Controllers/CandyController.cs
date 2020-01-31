using CandyShop.DomainModels;
using CandyShop.Persistence.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepo _candyRepo;
        private readonly ICategoryRepo _categoryRepo;

        public CandyController(ICandyRepo candyRepo, ICategoryRepo categoryRepo)
        {
            _candyRepo = candyRepo;
            _categoryRepo = categoryRepo;
        }

        public ViewResult List()
        {
            //ViewBag.CurrentCategory = "BestSellers";
            //return View(_candyRepo.GetAllCandy);
            var model = new CandyListViewModel();
            model.Candies = _candyRepo.GetAllCandy;
            model.CurrentCategory = "BestSellers";
            return View(model);
        }
    }
}
