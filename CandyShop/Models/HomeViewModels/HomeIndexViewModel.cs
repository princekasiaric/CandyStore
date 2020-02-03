using CandyShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models.HomeViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Candy> CandyOnSale { get; set; }
    }
}
