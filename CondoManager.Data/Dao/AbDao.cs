using CondoManager.Data.Context;
using CondoManager.Data.Model;
using System.Data.Entity;

namespace CondoManager.Data.Dao
{
    public abstract class AbDao<T> where T : AbEntity
    {
        private CondoManagerContext _context;
        private DbSet<T> _dbSet;

        public AbDao(CondoManagerContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T Insert(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
