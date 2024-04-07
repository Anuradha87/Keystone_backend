using Keystone.Application.Repositories;
using Keystone.Domain.Common;
using Keystone.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;

public class BaseRepository<T>(DataContext context) : IBaseRepository<T>
    where T : BaseEntity
{
    protected readonly DataContext Context = context;

    public void Create(T entity)
    {
        Context.Add(entity);
    }

    public void Update(T entity)
    {
        Context.Update(entity);
    }

    public void Delete(T entity)
    {
        entity.DateCreated = DateTimeOffset.UtcNow;
        Context.Update(entity);
    }

    public Task<T> Get(Guid id, CancellationToken cancellationToken)
    {
        return Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return Context.Set<T>().ToListAsync(cancellationToken);
    }

    public async Task BulkInsert(List<T> entities, CancellationToken cancellationToken)
    {
        await Context.AddRangeAsync(entities, cancellationToken);
    }
    
    public async Task<IQueryable<T>> Query(CancellationToken cancellationToken = default)
    {
        return Context.Set<T>().AsQueryable();
    }
}