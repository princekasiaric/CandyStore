using CandyShop.Domain.Models;
using System.Collections.Generic;

namespace CandyShop.Service.Services
{
    public interface ICategoryService 
    {
        IEnumerable<Category> GetCategories { get; }
        string GetCategoryName(string category);
    }
}
