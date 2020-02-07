using CandyShop.DomainModels;
using CandyShop.Models;
using CandyShop.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyService _candyService;

        public CandyController(ICandyService candyService)
        {
            _candyService = candyService;
        }

        public IActionResult List()
        {
            var model = new CandyListViewModel
            {
                Candies = _candyService.GetAllCandies,
                CurrentCategory = "BestSellers"
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var candy = _candyService.GetCandyByIdAsync(id);
            if (candy == null)
            {
                return NotFound();
            }
            return View(candy);
        }
    }
}
