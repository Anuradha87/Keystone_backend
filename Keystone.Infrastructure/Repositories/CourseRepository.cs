using CleanArchitecture.Persistence.Repositories;
using Keystone.Application.Repositories;
using Keystone.Domain.Entities;
using Keystone.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Keystone.Infrastructure.Repositories;

public class CourseRepository(DataContext context) : BaseRepository<Course>(context), ICourseRepository
{
    public Task<Course?> GetByTitle(string courseName, CancellationToken cancellationToken)
    {
        return Context.Courses.FirstOrDefaultAsync(x => x.Name == courseName, cancellationToken);
    }
}