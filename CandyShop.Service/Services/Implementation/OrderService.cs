using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository;
using System.Threading.Tasks;

namespace CandyShop.Service.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IShoppingCartRepo _shoppingCartRepo;
        private readonly IOrderDetailRepo _orderDetailRepo;

        public OrderService(IOrderRepo orderRepo, IShoppingCartRepo shoppingCartRepo, IOrderDetailRepo orderDetailRepo)
        {
           _orderRepo = orderRepo;
           _shoppingCartRepo = shoppingCartRepo;
           _orderDetailRepo = orderDetailRepo;
        }

        public async Task CreateOrder(Order order)
        {
            _orderRepo.CreatOrder(order);
            await _orderRepo.Add(order);
            await _orderRepo.SaveAsync();

            var shoppingCartItems = _shoppingCartRepo.GetShoppingCartItems();

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                     Amount = shoppingCartItem.Amount,
                     Price = shoppingCartItem.Candy.Price,
                     CandyId = shoppingCartItem.Candy.CandyId,
                     OrderId = order.OrderId
                };
                await _orderDetailRepo.Add(orderDetail);
            }

            await _orderRepo.SaveAsync();
        }
    }
}
