namespace MotoApp3.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Project.Entities;

public class ProjectAppDbContext : DbContext
{
    public DbSet<Customers> Customers => Set<Customers>();

    public DbSet<Cars> Cars => Set<Cars>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("StorageAppDb");
    }
}
