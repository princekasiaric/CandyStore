using CandyShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Service.Services
{
    public interface IShoppingCartService
    {
        string ShoppingCartId { get; set; }
        IList<ShoppingCartItem> ShoppingCartItems { get; set; }
        decimal GetShoppingCartTotalAsync();
        IList<ShoppingCartItem> GetShoppingCartItemsAsync();
        Task ClearCartsAsync();
        Task<int> RemoveFromCartAsync(Candy candy);
        //void GetCartAsync(IServiceProvider serviceProvider);
        Task AddToCartAsync(Candy candy, int numberOfItems);
    }
}
