using System.Security.Cryptography.X509Certificates;

using ConsoleApp.Persistence.entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ConsoleApp.Persistence;

public class ConsoleAppDbContext : DbContext
{
    public ConsoleAppDbContext(DbContextOptions<ConsoleAppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConsoleAppDbContext).Assembly);
    }
}


