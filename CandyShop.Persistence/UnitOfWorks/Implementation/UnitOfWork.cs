using CandyShop.Persistence.Repository;
using System.Threading.Tasks;

namespace CandyShop.Persistence.UnitOfWorks.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Candies = new CandyRepo(_context);
            Categories = new CategoryRepo(_context);
        }

        public ICandyRepo Candies { get; }

        public ICategoryRepo Categories { get; }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (_context == null)
            {
                _context.Dispose();
            }
        }
    }
}
