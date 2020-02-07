using CandyShop.Domain.Models;
using System.Collections.Generic;

namespace CandyShop.DomainModels
{
    public class CandyListViewModel
    {
        public IEnumerable<Candy> Candies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
