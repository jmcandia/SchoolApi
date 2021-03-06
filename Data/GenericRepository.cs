using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolApi.Data
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _dataContext;
        private readonly string _entityName = typeof(TEntity).FullName;
        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(TEntity entity)
        {
            _dataContext.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dataContext.Set<TEntity>().Remove(entity);
        }

        public async Task<TEntity> Get(object id)
        {
            TEntity entity = await _dataContext.Set<TEntity>().FindAsync(id);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            IEnumerable<TEntity> entities = await _dataContext.Set<TEntity>().ToListAsync();
            return entities;
        }

        public async Task<bool> SaveAll()
        {
            int result = await _dataContext.SaveChangesAsync();
            return result > 0;
        }

        public void Update(TEntity entity)
        {
            _dataContext.Set<TEntity>().Update(entity);
        }
    }
}