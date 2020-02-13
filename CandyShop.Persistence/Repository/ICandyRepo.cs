using CandyShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository
{
    public interface ICandyRepo : IBaseRepo<Candy>
    {
        IEnumerable<Candy> GetCandyByOrderBy { get; }
        IEnumerable<Candy> GetAllCandy { get; }
        IEnumerable<Candy> GetCandyOnSale { get; }
        Candy GetCandyById(int candyId);
        void Update(Candy candy);
    }
}
