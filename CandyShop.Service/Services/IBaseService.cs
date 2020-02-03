using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyShop.Service.Services
{
    public interface IBaseService<TEntity> where TEntity : class 
    {
        Task CreateAsync(TEntity entity);
        Task EditAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
