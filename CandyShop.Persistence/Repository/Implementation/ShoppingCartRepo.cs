using CandyShop.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CandyShop.Persistence.Repository.Implementation
{
    public class ShoppingCartRepo : BaseRepo<ShoppingCartItem>, IShoppingCartRepo
    {
        public string ShoppingCartId { get; set; }
        public IList<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCartRepo(AppDbContext context) : base(context){ }

        public static ShoppingCartRepo GetCart(IServiceProvider serviceProvider)
        {
            ISession session = serviceProvider.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = serviceProvider.GetService<AppDbContext>();
            string cartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();
            session.SetString("cartId", cartId);

            return new ShoppingCartRepo(context) { ShoppingCartId = cartId };
        }

        public ShoppingCartItem AddToCart(Candy candy)
        {
            var shoppingCartItem = AppDbContext.ShoppingCartItems.SingleOrDefault(s => s.Candy.CandyId == candy.CandyId
                                                                                  && s.ShoppingCartId == ShoppingCartId);
            return shoppingCartItem;
        }

        public IList<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = AppDbContext.ShoppingCartItems
                                                             .Where(c => c.ShoppingCartId == ShoppingCartId)
                                                             .Include(c => c.Candy).ToList());
        }

        public IList<ShoppingCartItem> ClearClart()
        {
            return AppDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).ToList();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = AppDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                                                      .Select(c => c.Candy.Price * c.Amount).Sum();
            return total;
        }

        public AppDbContext AppDbContext => _context as AppDbContext;
    }
}
