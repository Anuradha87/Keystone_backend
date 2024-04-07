using Keystone.Application.Repositories;
using Keystone.Infrastructure.Context;

namespace Keystone.Infrastructure.Repositories;

public class UnitOfWork(DataContext context) : IUnitOfWork
{
    public Task Save(CancellationToken cancellationToken)
    {
        return context.SaveChangesAsync(cancellationToken);
    }
}