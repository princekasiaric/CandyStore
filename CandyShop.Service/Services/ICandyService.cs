using CandyShop.Domain.Models;
using System.Collections.Generic;

namespace CandyShop.Service.Services
{
    public interface ICandyService : IBaseService<Candy>
    {
        public IEnumerable<Candy> GetAllCandies { get; }
        public IEnumerable<Candy> GetCandiesOnSale { get; }
        Candy GetCandyByIdAsync(int candyId);
    }
}
