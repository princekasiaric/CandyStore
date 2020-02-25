using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Service.Services.Implementation
{
    public class ShoppingCartService  : IShoppingCartService
    {
        private readonly IShoppingCartRepo _shoppingCartRepo;
        private readonly IShoppingCartItemRepo _shoppingCartItemRepo;

        public string ShoppingCartId { get => _shoppingCartRepo.ShoppingCartId; 
            set => _shoppingCartRepo.ShoppingCartId = value; }

        public IList<ShoppingCartItem> ShoppingCartItems { get => _shoppingCartRepo.ShoppingCartItems; 
            set => _shoppingCartRepo.ShoppingCartItems = value; }

        public ShoppingCartService(IShoppingCartRepo shoppingCartRepo, IShoppingCartItemRepo shoppingCartItemRepo)
        {
            _shoppingCartRepo = shoppingCartRepo;
            _shoppingCartItemRepo = shoppingCartItemRepo;
        }

        public async Task AddToCartAsync(Candy candy, int numberOfItems)
        {
            var shoppingCartItem = _shoppingCartRepo.AddToCart(candy);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Candy = candy,
                    Amount = numberOfItems
                };
                await _shoppingCartItemRepo.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            var rowsAffected = _shoppingCartItemRepo.SaveAsync();
        }

        public int RemoveFromCartAsync(Candy candy)
        {
            var amount = 0;
            var shoppingCartItem = _shoppingCartRepo.AddToCart(candy);

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    amount = shoppingCartItem.Amount;
                }
                else
                {
                    _shoppingCartItemRepo.Remove(shoppingCartItem);
                }
                _shoppingCartItemRepo.SaveAsync();
            }

            return amount;
        }

        public IList<ShoppingCartItem> GetShoppingCartItemsAsync()
        {
            var shoppingCartItem = _shoppingCartRepo.GetShoppingCartItems();
            return shoppingCartItem;
        }

        public void ClearCartsAsync()
        {
            var clearCarts = _shoppingCartRepo.ClearClart();
            _shoppingCartItemRepo.RemoveRange(clearCarts);
            _shoppingCartItemRepo.SaveAsync();
        }

        public decimal GetShoppingCartTotalAsync()
        {
            return _shoppingCartRepo.GetShoppingCartTotal();
        }
    }
}
