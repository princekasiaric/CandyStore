using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository.Implementation;
using CandyShop.Persistence.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Service.Services.Implementation
{
    public class ShoppingCartService  : IShoppingCartService
    {
        private readonly IUnitOfWork _unitOfWork;

        public string ShoppingCartId { get; set; }

        public ShoppingCartService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task GetCartAsync(IServiceProvider serviceProvider)
        {
            var getCarts = ShoppingCartRepo.GetCart(serviceProvider);
        }

        public async Task AddToCartAsync(Candy candy, int numberOfItems)
        {
            var shoppingCartItem = _unitOfWork.ShoppingCarts.AddToCart(candy);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Candy = candy,
                    Amount = numberOfItems
                };
                await _unitOfWork.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            await _unitOfWork.CommitAsync();
            _unitOfWork.Dispose();
        }

        public async Task<int> RemoveFromCartAsync(Candy candy)
        {
            var amount = 0;
            var shoppingCartItem = _unitOfWork.ShoppingCarts.AddToCart(candy);

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    amount = shoppingCartItem.Amount;
                }
                else
                {
                    _unitOfWork.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            await _unitOfWork.CommitAsync();
            _unitOfWork.Dispose();

            return amount;
        }

        public void GetShoppingCartItemsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task ClearCartsAsync()
        {
            var clearClarts = _unitOfWork.ShoppingCarts.ClearClart();
            _unitOfWork.ShoppingCartItems.RemoveRange(clearClarts);
            await _unitOfWork.CommitAsync();
        }
    }
}
