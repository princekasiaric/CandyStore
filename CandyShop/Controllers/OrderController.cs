using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository;
using CandyShop.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IShoppingCartService _shoppingCartService;

        public OrderController(IOrderService orderService, IShoppingCartService shoppingCartService)
        {
            _orderService = orderService;
            _shoppingCartService = shoppingCartService;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(Order order)
        {
            _shoppingCartService.ShoppingCartItems = _shoppingCartService.GetShoppingCartItemsAsync();
            if (_shoppingCartService.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your Cart is Empty");
            }

            if (ModelState.IsValid)
            {
                await _orderService.CreateOrder(order);
                _shoppingCartService.ClearCartsAsync();
                return RedirectToAction(nameof(CheckoutComplete));
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank you for your order. Enjoy your candy";
            return View();
        }
    }
}
