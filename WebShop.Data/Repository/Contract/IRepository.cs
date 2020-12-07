using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebShop.Data.Repository.Contract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        void AddAsync(TEntity entity);

        void RemoveAsync(TEntity entity);

    }
}
