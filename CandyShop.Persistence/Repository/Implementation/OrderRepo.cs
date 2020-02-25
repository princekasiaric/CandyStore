using CandyShop.Domain.Models;
using System;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository.Implementation
{
    public class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        private readonly IShoppingCartRepo _shoppingCartRepo;

        public OrderRepo(AppDbContext context, IShoppingCartRepo shoppingCartRepo) : base(context)
        {
            _shoppingCartRepo = shoppingCartRepo;
        }

        public void CreatOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCartRepo.GetShoppingCartTotal();
        }

        public async Task<int> SaveAsync()
        {
            return await AppDbContext.SaveChangesAsync();
        }

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}
