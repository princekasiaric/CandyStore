using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository;
using System.Collections.Generic;

namespace CandyShop.Service.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;

        public CategoryService(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public IEnumerable<Category> GetCategories => _categoryRepo.GetAllCategories;

        public string GetCategoryName(string category)
        {
            return _categoryRepo.GetCategoryByName(category);
        }
    }
}
