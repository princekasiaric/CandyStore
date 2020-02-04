using CandyShop.Domain.Models;
using System.Collections.Generic;

namespace CandyShop.Models.HomeViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Candy> CandyOnSale { get; set; }
    }
}
