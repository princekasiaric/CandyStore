using CandyShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository
{
    public interface IShoppingCartRepo : IBaseRepo<ShoppingCartItem>
    {
        int SaveAsync();
        string ShoppingCartId { get; set; }
        IList<ShoppingCartItem> ShoppingCartItems { get; set; }
        decimal GetShoppingCartTotal();
        IList<ShoppingCartItem> ClearClart();
        IList<ShoppingCartItem> GetShoppingCartItems();
        ShoppingCartItem AddToCart(Candy candy);
    }
}
