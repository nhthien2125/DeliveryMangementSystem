using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using DeliveryMangementSystem.Models;
using System.Linq.Expressions;
using System.Linq;


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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myDbContext"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    public DbSet<BRANCH> Branches { get; set; }
    public DbSet<CUSTOMER> Customers { get; set; }
    public DbSet<SHIPPER> Shippers { get; set; }
    public DbSet<xORDER> Orders { get; set; }
    public DbSet<ACCOUNT> Accounts { get; set; }
}
