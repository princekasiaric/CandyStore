using CandyShop.Service.Services;
using System.Threading.Tasks;

namespace CandyShop.Models.ShoppingCartViewModels
{
    public class ShoppingCartIndexViewModel
    {
        public IShoppingCartService ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
