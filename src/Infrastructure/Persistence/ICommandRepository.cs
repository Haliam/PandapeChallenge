using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pandape.Infrastructure.Persistence
{
    public interface ICommandRepository<T> where T : class
    {
        Task Insert(T entity);

        Task InsertRange(IEnumerable<T> entities);

        Task Update(T entity);

        Task Delete(T entity);

        Task Delete(object id);

        Task DeleteRange(IEnumerable<T> entities);
    }
}