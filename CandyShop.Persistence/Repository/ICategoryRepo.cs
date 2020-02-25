using CandyShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository
{
    public interface ICategoryRepo
    {
        int SaveAsync();
        IEnumerable<Category> GetAllCategories { get; }
        string GetCategoryByName(string category);
    }
}
