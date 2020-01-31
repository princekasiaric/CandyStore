using CandyShop.Domain.Models;
using System.Collections.Generic;

namespace CandyShop.Persistence.Repository
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetAllCategorires { get; }
    }
}
