using Keystone.Domain.Entities;

namespace Keystone.Application.Repositories;

public interface ICourseRepository : IBaseRepository<Course>
{
    Task<Course?> GetByTitle(string title, CancellationToken cancellationToken);
}