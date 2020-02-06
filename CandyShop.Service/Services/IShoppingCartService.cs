using CandyShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Service.Services
{
    public interface IShoppingCartService
    {
        void GetShoppingCartItemsAsync();
        Task ClearCartsAsync();
        Task<int> RemoveFromCartAsync(Candy candy);
        Task GetCartAsync(IServiceProvider serviceProvider);
        Task AddToCartAsync(Candy candy, int numberOfItems);
    }
}
