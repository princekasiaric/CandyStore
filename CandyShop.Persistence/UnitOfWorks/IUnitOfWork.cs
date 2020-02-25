//using CandyShop.Persistence.Repository;
//using System;
//using System.Threading.Tasks;

//namespace CandyShop.Persistence.UnitOfWorks
//{
//    public interface IUnitOfWork : IDisposable, IAsyncDisposable
//    {
//        Task BeginTransactionAsync();
//        IOrderRepo Orders { get; }
//        ICandyRepo Candies { get; }
//        ICategoryRepo Categories { get; }
//        IOrderDetailRepo OrderDetails { get; }
//        IShoppingCartRepo ShoppingCarts { get; }
//        IShoppingCartItemRepo ShoppingCartItems { get; }

//        int Save();
//        Task<int> SaveAsync();
//        Task CommitAsync();
//        Task RollbackAsync();

//    }
//}
