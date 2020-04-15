using CandyShop.Domain.Models;
using CandyShop.Persistence.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Service.Services.Implementation
{
    public class CandyService : ICandyService
    {
        private readonly ICandyRepo _candyRepo;

        public CandyService(ICandyRepo candyRepo)
        {
            _candyRepo = candyRepo;
        }

        public IEnumerable<Candy> GetAllCandies => _candyRepo.GetAllCandy;

        public IEnumerable<Candy> GetCandiesOnSale => _candyRepo.GetCandyOnSale;

        public IEnumerable<Candy> GetCandyByOrderBy => _candyRepo.GetCandyByOrderBy;

        public Candy GetCandyByIdAsync(int candyId)
        {
            return _candyRepo.GetCandyById(candyId);
        }

        public IEnumerable<Candy> GetCandyWithCategory(string category)
        {
            return _candyRepo.FindByCondition(c => c.Category.CategoryName == category);
        }
    }
}
