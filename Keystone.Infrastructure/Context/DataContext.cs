using Keystone.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Keystone.Infrastructure.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Course> Courses { get; set; }
}