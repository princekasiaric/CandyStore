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

        public async Task<IActionResult> Details(int id)
        {
            var candy = await _candyService.GetCandyById(id);
            if (candy == null)
            {
                return NotFound();
            }
            //var model = new CandyDetailsViewModel
            //{
            //    Name = candy.Name,
            //    ImageUrl = candy.ImageUrl,
            //    Price = candy.Price,
            //    Description = candy.Description
            //};
            return View(candy);
        }
    }
}
