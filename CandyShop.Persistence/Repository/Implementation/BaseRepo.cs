using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop.Persistence.Repository.Implementation
{
    public abstract class BaseRepo<TEntity> : IBaseRepo<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;

        public BaseRepo(DbContext context)
        {
            _context = context;
        }

        public async Task Add(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public IEnumerable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).AsNoTracking();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}
