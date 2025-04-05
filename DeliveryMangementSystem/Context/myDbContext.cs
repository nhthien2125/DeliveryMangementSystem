using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using DeliveryMangementSystem.Models;
using System.Linq.Expressions;
using System.Linq;
using DeliveryMangementSystem._1.Models_Configer;


public class myDbContext : DbContext
{
    public myDbContext() : base() { }

    //ID Generator
    public string GenerateNewId<TEntity>(DbSet<TEntity> dbSet, Expression<Func<TEntity, string>> idSelector, string prefix) where TEntity : class
    {
        var existingIds = dbSet
            .Where(e => EF.Functions.Like(EF.Property<string>(e, ((MemberExpression)idSelector.Body).Member.Name), prefix + "%"))
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

    //Config Connection String
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myDbContext"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    //Config Model
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new BranchConfig());
        modelBuilder.ApplyConfiguration(new CustomerConfig());
        modelBuilder.ApplyConfiguration(new ShipperConfig());
        modelBuilder.ApplyConfiguration(new OrderConfig());
        modelBuilder.ApplyConfiguration(new AccountConfig());
    }

    public DbSet<BRANCH> Branches { get; set; }
    public DbSet<CUSTOMER> Customers { get; set; }
    public DbSet<SHIPPER> Shippers { get; set; }
    public DbSet<ORDER> Orders { get; set; }
    public DbSet<ACCOUNT> Accounts { get; set; }
}
