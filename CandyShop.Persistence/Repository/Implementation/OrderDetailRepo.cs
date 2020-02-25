using CandyShop.Domain.Models;

namespace CandyShop.Persistence.Repository.Implementation
{
    public class OrderDetailRepo : BaseRepo<OrderDetail>, IOrderDetailRepo
    {
        public OrderDetailRepo(AppDbContext context) : base(context){}

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}
