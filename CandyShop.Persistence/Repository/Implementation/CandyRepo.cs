using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository
{
    public class CandyRepo : BaseRepo<Candy>, ICandyRepo
    {
        public CandyRepo(AppDbContext context) : base(context){ }

        public IEnumerable<Candy> GetAllCandy 
        {
            get
            {
                return AppDbContext.Candies.Include(c => c.Category).AsNoTracking();
            }
        }

        public IEnumerable<Candy> GetCandyOnSale
        {
            get
            {
                return AppDbContext.Candies.Include(c => c.Category).Where(c => c.IsOnSale).AsNoTracking();
            }
        }

        public Candy GetCandyById(int candyId)
        {
            return AppDbContext.Candies.FirstOrDefault(c => c.CandyId == candyId);
        }

        public IEnumerable<Candy> GetCandyByOrderBy
        {
            get
            {
                return AppDbContext.Candies.OrderBy(c => c.CandyId);
            }
        }

        public void Update(Candy candy)
        {
            _context.Update(candy);
        }

        public int SaveAsync()
        {
            return AppDbContext.SaveChanges();
        }

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}
