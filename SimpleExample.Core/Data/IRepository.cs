using System;
using System.Threading.Tasks;

namespace SimpleExample.Core.Data
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> Get(Guid id);
        Task<bool> Save();
    }
}
