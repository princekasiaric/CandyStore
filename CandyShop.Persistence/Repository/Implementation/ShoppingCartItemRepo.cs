using CandyShop.Domain.Models;

namespace CandyShop.Persistence.Repository.Implementation
{
    public class ShoppingCartItemRepo : BaseRepo<ShoppingCartItem>, IShoppingCartItemRepo
    {
        public ShoppingCartItemRepo(AppDbContext context) : base(context) { }

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}
