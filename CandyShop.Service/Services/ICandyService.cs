using CandyShop.Domain.Models;
using System.Collections.Generic;

namespace CandyShop.Service.Services
{
    public interface ICandyService 
    {
        IEnumerable<Candy> GetCandyByOrderBy { get; }
        IEnumerable<Candy> GetAllCandies { get; }
        IEnumerable<Candy> GetCandiesOnSale { get; }
        IEnumerable<Candy> GetCandyWithCategory(string category);
        Candy GetCandyByIdAsync(int candyId);

    }
}
