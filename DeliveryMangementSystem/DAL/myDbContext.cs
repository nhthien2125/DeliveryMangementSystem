using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using DeliveryMangementSystem.Models;
using DAL._1._Configurations;


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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new AccountConfig());
        modelBuilder.ApplyConfiguration(new BranchConfig());
        modelBuilder.ApplyConfiguration(new ShipperConfig());
        modelBuilder.ApplyConfiguration(new CustomerConfig());
        modelBuilder.ApplyConfiguration(new OrderConfig());
    }

    public DbSet<Branch> Branches { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Shipper> Shippers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Account> Accounts { get; set; }
}
