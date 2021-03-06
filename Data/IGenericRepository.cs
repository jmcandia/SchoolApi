using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolApi.Data
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> Get(object id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<bool> SaveAll();
        void Update(TEntity entity);
    }
}