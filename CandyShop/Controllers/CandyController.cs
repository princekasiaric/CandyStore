using CandyShop.Domain.Models;
using CandyShop.DomainModels;
using CandyShop.Models;
using CandyShop.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyService _candyService;
        private readonly ICategoryService _categoryService;

        public CandyController(ICandyService candyService, ICategoryService categoryService)
        {
            _candyService = candyService;
            _categoryService = categoryService;
        }

        public IActionResult List(string category)
        {
            IEnumerable<Candy> candies;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                candies = _candyService.GetCandyByOrderBy;
                currentCategory = "All Candy";
            }
            else
            {
                candies = _candyService.GetCandyWithCategory(category);
                currentCategory = _categoryService.GetCategoryName(category);
            }
            return View(new CandyListViewModel { Candies = candies, CurrentCategory = currentCategory });
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
