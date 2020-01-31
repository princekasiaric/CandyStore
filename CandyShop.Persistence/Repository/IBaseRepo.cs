using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository
{
    public interface IBaseRepo<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> predicate);
        Task Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
