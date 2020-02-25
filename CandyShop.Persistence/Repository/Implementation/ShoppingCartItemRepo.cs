using CandyShop.Domain.Models;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository.Implementation
{
    public class ShoppingCartItemRepo : BaseRepo<ShoppingCartItem>, IShoppingCartItemRepo
    {
        public ShoppingCartItemRepo(AppDbContext context) : base(context) { }

        //public async Task<int> SaveAsync()
        //{
        //    return await AppDbContext.SaveChangesAsync();
        //}

        public int SaveAsync()
        {
            return AppDbContext.SaveChanges();
        }

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}
