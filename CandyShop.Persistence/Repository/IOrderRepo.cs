using CandyShop.Domain.Models;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository
{
    public interface IOrderRepo : IBaseRepo<Order>
    {
        void CreatOrder(Order order);
        Task<int> SaveAsync();
    }
}
