using CandyShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository
{
    public interface IShoppingCartRepo : IBaseRepo<ShoppingCartItem>
    {
        Task<decimal> GetShoppingCartTotal();
        List<ShoppingCartItem> ClearClart();
        List<ShoppingCartItem> GetShoppingCartItems();
        ShoppingCartItem AddToCart(Candy candy);
    }
}
