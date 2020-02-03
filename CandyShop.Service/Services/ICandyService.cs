using CandyShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Service.Services
{
    public interface ICandyService : IBaseService<Candy>
    {
        public IEnumerable<Candy> GetAllCandies { get; }
        public IEnumerable<Candy> GetCandiesOnSale { get; }
        Task<Candy> GetCandyById(int id);
    }
}
