using Keystone.Domain.Common;

namespace Keystone.Application.Repositories;

public interface IBaseRepository<T> where T : BaseEntity
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> Get(Guid id, CancellationToken cancellationToken);
    Task<List<T>> GetAll(CancellationToken cancellationToken);
    Task BulkInsert(List<T> entities, CancellationToken cancellationToken);
    Task<IQueryable<T>> Query(CancellationToken cancellationToken);
}