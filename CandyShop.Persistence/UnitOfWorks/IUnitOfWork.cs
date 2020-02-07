using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Persistence.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        ICandyRepo Candies { get; }
        ICategoryRepo Categories { get; }
        IShoppingCartRepo ShoppingCarts { get; }
        IShoppingCartItemRepo ShoppingCartItems { get; }

        Task<int> CommitAsync();
    }
}
