using CandyShop.Service.Services;

namespace CandyShop.Models.ShoppingCartViewModels
{
    public class ShoppingCartIndexViewModel
    {
        public IShoppingCartService ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
