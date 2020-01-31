using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CandyShop.Persistence.Repository
{
    public class CandyRepo : BaseRepo<Candy>, ICandyRepo
    {
        public CandyRepo(AppDbContext context) : base(context){ }

        public IEnumerable<Candy> GetAllCandy 
        {
            get
            {
                return AppDbContext.Candies.Include(c => c.Category);
            }
        }

        public IEnumerable<Candy> GetCandyOnSale
        {
            get
            {
                return AppDbContext.Candies.Include(c => c.Category).Where(c => c.IsOnSale);
            }
        }

        public Candy GetCandyById(int candyId)
        {
            return AppDbContext.Candies.FirstOrDefault(c => c.CandyId.Equals(candyId));
        }

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}
