using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using dbShipper.Models;


public class myDbContext : DbContext
{
    public DbSet<Shipper> Shippers { get; set; }

    public myDbContext() : base() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myDbContext"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
