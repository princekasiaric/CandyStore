using CandyShop.Domain.Models;
using CandyShop.Persistence.UnitOfWorks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Service.Services.Implementation
{
    public class ShoppingCartService  : IShoppingCartService
    {
        private readonly IUnitOfWork _unitOfWork;

        public string ShoppingCartId { get => _unitOfWork.ShoppingCarts.ShoppingCartId; set => _unitOfWork.ShoppingCarts.ShoppingCartId = value; }

        public IList<ShoppingCartItem> ShoppingCartItems { get => _unitOfWork.ShoppingCarts.ShoppingCartItems; set => _unitOfWork.ShoppingCarts.ShoppingCartItems = value; }

        public ShoppingCartService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
            //_unitOfWork.Dispose();
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

            return amount;
        }

        public IList<ShoppingCartItem> GetShoppingCartItemsAsync()
        {
            var shoppingCartItem = _unitOfWork.ShoppingCarts.GetShoppingCartItems();
            return shoppingCartItem;
        }

        public async Task ClearCartsAsync()
        {
            var clearClarts = _unitOfWork.ShoppingCarts.ClearClart();
            _unitOfWork.ShoppingCartItems.RemoveRange(clearClarts);
            await _unitOfWork.CommitAsync();
            _unitOfWork.Dispose();
        }

        public decimal GetShoppingCartTotalAsync()
        {
            return _unitOfWork.ShoppingCarts.GetShoppingCartTotal();
        }
    }
}
