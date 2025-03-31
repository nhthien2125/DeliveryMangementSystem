using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using DeliveryMangementSystem.Models;


public class myDbContext : DbContext
{
    public myDbContext() : base() { }

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
