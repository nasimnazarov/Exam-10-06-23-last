using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Update.Internal;

namespace Infrastructure.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)  : base(options)
    {
        
    }

    public DbSet<Job> Jobs { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<JobGrade> JobsGrades { get; set; }
    public DbSet<JobHistory> JobHistories { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Employee> Employees { get; set; }
}