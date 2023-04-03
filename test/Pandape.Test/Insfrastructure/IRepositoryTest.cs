using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pandape.Test.Insfrastructure
{
    public interface IRepositoryTest<T> where T : class
    {
        Task GetAll_ShouldReturnAllEntities(List<T> entities, int range);

        Task GetById_ShouldReturnEntity(T entity);

        Task Insert_ShouldAddEntityToDatabase(T entity);

        Task InsertRange_ShouldAddEntitiesToDatabase(List<T> entities, int range);

        Task DeleteByEntity_ShouldRemoveEntityFromDatabase(T entity);

        Task DeleteById_ShouldRemoveEntityFromDatabase(T entity);

        Task DeleteRange_ShouldRemoveEntitiesFromDatabase(List<T> entities, int range);
    }
}
