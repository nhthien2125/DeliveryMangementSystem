using DeliveryMangementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DAL._1._Configurations;
using System.Linq.Expressions;
using System;
using System.Linq;

public class myDbContext : DbContext
{
    public myDbContext() : base() { }

    //ID Generator
    public string GenerateNewId<TEntity>(DbSet<TEntity> dbSet, Expression<Func<TEntity, string>> idSelector, string prefix) where TEntity : class
    {
        var existingIds = dbSet
            .Where(e => EF.Functions.Like(idSelector.Compile().Invoke(e), prefix + "%"))
            .Select(idSelector)
            .ToList();

        var existingIdNumbers = existingIds
            .Select(id => int.Parse(id.Substring(prefix.Length)))
            .OrderBy(n => n)
            .ToList();

        int newIdNumber = 1;
        foreach (var idNumber in existingIdNumbers)
        {
            if (newIdNumber < idNumber)
            {
                break;
            }
            newIdNumber++;
        }

        return prefix + newIdNumber.ToString().PadLeft(3, '0');
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GIMI71A;Database=DELIVERY_SYSTEM_MANAGEMENT;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new BranchConfig());
        modelBuilder.ApplyConfiguration(new CustomerConfig());
        modelBuilder.ApplyConfiguration(new ShipperConfig());
        modelBuilder.ApplyConfiguration(new OrderConfig());
        modelBuilder.ApplyConfiguration(new AccountConfig());
    }

    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Shipper> Shippers { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Account> Accounts { get; set; }
}
