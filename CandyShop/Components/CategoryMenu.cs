using CandyShop.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryMenu(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetCategories;
            return View(categories);
        }
    }
}
