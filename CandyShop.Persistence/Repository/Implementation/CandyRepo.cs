using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<Candy> GetCandyById(int candyId)
        {
            return await AppDbContext.Candies.FirstOrDefaultAsync(c => c.CandyId == candyId);
        }

        public void Update(Candy candy)
        {
            _context.Update(candy);
        }

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}
