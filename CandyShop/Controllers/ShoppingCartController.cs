using CandyShop.Models.ShoppingCartViewModels;
using CandyShop.Persistence.Repository;
using CandyShop.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly ICandyService _candyService;
        private readonly IShoppingCartRepo _shoppingCart;

        public ShoppingCartController(IShoppingCartService shoppingCartService, 
                                      ICandyService candyService, 
                                      IShoppingCartRepo shoppingCart)
        {
            _shoppingCartService = shoppingCartService;
            _candyService = candyService;
            _shoppingCart = shoppingCart;
            _shoppingCartService.ShoppingCartId = _shoppingCart.ShoppingCartId;
        }

        public IActionResult Index()
        {
            _shoppingCartService.ShoppingCartItems = _shoppingCartService.GetShoppingCartItemsAsync();
            var model = new ShoppingCartIndexViewModel
            {
                ShoppingCart = _shoppingCartService,
                ShoppingCartTotal = _shoppingCartService.GetShoppingCartTotalAsync()
            };
            return View(model);
        }

        public IActionResult AddToShoppingCart(int candyId)
        {
            var candy = _candyService.GetCandyByIdAsync(candyId);
            if (candy != null)
            {
                _shoppingCartService.AddToCartAsync(candy, 1);
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveFromShoppingCart(int candyId)
        {
            var candy = _candyService.GetCandyByIdAsync(candyId);
            if (candy != null)
            {
                _shoppingCartService.RemoveFromCartAsync(candy);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
