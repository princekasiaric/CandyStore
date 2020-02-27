using CandyShop.Domain.Models;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository.Implementation
{
    public class OrderDetailRepo : BaseRepo<OrderDetail>, IOrderDetailRepo
    {
        public OrderDetailRepo(AppDbContext context) : base(context){ }

        public async Task<int> SaveAsync()
        {
            return await AppDbContext.SaveChangesAsync();
        }

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}
