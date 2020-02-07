using CandyShop.Models.ShoppingCartViewModels;
using CandyShop.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly ICandyService _candyService;

        public ShoppingCartController(IShoppingCartService shoppingCartService, ICandyService candyService)
        {
            _shoppingCartService = shoppingCartService;
            _candyService = candyService;
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
