using CandyShop.Domain.Models;
using CandyShop.Persistence.UnitOfWorks;
using System.Collections.Generic;

namespace CandyShop.Service.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetCategories => _unitOfWork.Categories.GetAllCategories;

        public string GetCategoryName(string category)
        {
            return _unitOfWork.Categories.GetCategoryByName(category);
        }
    }
}
