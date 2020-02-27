using CandyShop.Domain.Models;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository
{
    public interface IOrderDetailRepo : IBaseRepo<OrderDetail>
    {
        Task<int> SaveAsync();
    }
}
