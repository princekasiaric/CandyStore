using CandyShop.Domain.Models;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository
{
    public interface IShoppingCartItemRepo : IBaseRepo<ShoppingCartItem>
    {
        int SaveAsync();
    }
}
