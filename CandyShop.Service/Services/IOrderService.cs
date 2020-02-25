using CandyShop.Domain.Models;
using System.Threading.Tasks;

namespace CandyShop.Service.Services
{
    public interface IOrderService 
    {
        Task CreateOrder(Order order);
    }
}
