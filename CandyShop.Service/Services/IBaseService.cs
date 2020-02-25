using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Service.Services
{
    public interface IBaseService<TEntity> where TEntity : class 
    {
        Task CreateAsync(TEntity entity);
        void EditAsync(TEntity entity);
        void DeleteAsync(TEntity entity);
    }
}
