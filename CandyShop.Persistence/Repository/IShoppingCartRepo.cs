using CandyShop.Domain.Models;
using System.Collections.Generic;

namespace CandyShop.Persistence.Repository
{
    public interface IShoppingCartRepo : IBaseRepo<ShoppingCartItem>
    {
        string ShoppingCartId { get; set; }
        IList<ShoppingCartItem> ShoppingCartItems { get; set; }
        decimal GetShoppingCartTotal();
        IList<ShoppingCartItem> ClearClart();
        IList<ShoppingCartItem> GetShoppingCartItems();
        ShoppingCartItem AddToCart(Candy candy);
    }
}
