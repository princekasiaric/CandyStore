using CandyShop.Domain.Models;
using System.Collections.Generic;

namespace CandyShop.Persistence.Repository
{
    public interface ICandyRepo : IBaseRepo<Candy>
    {
        int SaveAsync();
        IEnumerable<Candy> GetCandyByOrderBy { get; }
        IEnumerable<Candy> GetAllCandy { get; }
        IEnumerable<Candy> GetCandyOnSale { get; }
        Candy GetCandyById(int candyId);
    }
}
