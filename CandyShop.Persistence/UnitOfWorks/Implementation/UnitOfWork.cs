//using CandyShop.Persistence.Repository;
//using CandyShop.Persistence.Repository.Implementation;
//using Microsoft.EntityFrameworkCore.Storage;
//using System;
//using System.Threading.Tasks;

//namespace CandyShop.Persistence.UnitOfWorks.Implementation
//{
//    public class UnitOfWork : IUnitOfWork
//    {
//        private readonly AppDbContext _context;
//        private bool _disposed = false;

//        public UnitOfWork(AppDbContext context)
//        {
//            _context = context;
//            Candies = new CandyRepo(_context);
//            Categories = new CategoryRepo(_context);
//            ShoppingCartItems = new ShoppingCartItemRepo(_context);
//            ShoppingCarts = new ShoppingCartRepo(_context);
//            Orders = new OrderRepo(_context, ShoppingCarts);
//            OrderDetails = new OrderDetailRepo(_context);
//        }

//        public IDbContextTransaction Transaction;

//        public ICandyRepo Candies { get; }// => new CandyRepo(_context);

//        public ICategoryRepo Categories { get; }// => new CategoryRepo(_context);

//        public IShoppingCartRepo ShoppingCarts { get; }// => new ShoppingCartRepo(_context);

//        public IShoppingCartItemRepo ShoppingCartItems { get; }// => new ShoppingCartItemRepo(_context);

//        public IOrderRepo Orders { get; }// => new OrderRepo(_context, ShoppingCarts);

//        public IOrderDetailRepo OrderDetails { get; }// => new OrderDetailRepo(_context);


//        public async Task BeginTransactionAsync() => Transaction = await _context.Database.BeginTransactionAsync();

//        public int Save() => _context.SaveChanges();

//        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

//        public async Task CommitAsync() => await Transaction.CommitAsync();

//        public async Task RollbackAsync() => await Transaction.RollbackAsync();

//        public async ValueTask DisposeAsync() => await _context.DisposeAsync();

//        protected virtual void Dispose(bool disposing)
//        {
//            if (!_disposed)
//            {
//                if (disposing)
//                {
//                    _context.Dispose();
//                }
//            }
//            _disposed = true;
//        }

//        public void Dispose()
//        {
//            Dispose(true);
//            GC.SuppressFinalize(this);
//        }
//    }
//}
