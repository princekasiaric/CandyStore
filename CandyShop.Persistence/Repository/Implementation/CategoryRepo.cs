using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository.Implementation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(AppDbContext context) : base(context){}

        public IEnumerable<Category> GetAllCategories => AppDbContext.Categories.OrderBy(c => c.CategoryName);

        public string GetCategoryByName(string category)
        {
            return AppDbContext.Categories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
        }

        public int SaveAsync()
        {
            return AppDbContext.SaveChanges();
        }

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}
