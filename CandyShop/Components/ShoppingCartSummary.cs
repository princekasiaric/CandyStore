using CandyShop.Models.ShoppingCartViewModels;
using CandyShop.Persistence.Repository;
using CandyShop.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartSummary(IShoppingCartService shoppingCartService, IShoppingCartRepo shoppingCartRepo)
        {
            _shoppingCartService = shoppingCartService;
        }

        public IViewComponentResult Invoke()
        {
            _shoppingCartService.ShoppingCartItems = _shoppingCartService.GetShoppingCartItemsAsync();
            var model = new ShoppingCartIndexViewModel
            {
                ShoppingCart = _shoppingCartService,
                ShoppingCartTotal = _shoppingCartService.GetShoppingCartTotalAsync()
            };
            return View(model);
        }
    }
}
