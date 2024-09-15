using Microsoft.EntityFrameworkCore;
using ConsoleApp1.Data.Entities;

namespace ConsoleApp1.Data;
public class MotoAppDbContext : DbContext
{
    public DbSet<Customer> Customers => Set<Customer>();

    public DbSet<Cars> Cars => Set<Cars>();

    public DbSet<Employee> Employee => Set<Employee>();

    public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("StorageAppDb");
    }

}

