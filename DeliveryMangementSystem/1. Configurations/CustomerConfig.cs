using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMangementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL._1._Configurations
{
    class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("CUSTOMER");
            builder.HasKey(x => x.Customer_ID);
            builder.Property(x => x.Customer_ID).HasMaxLength(10);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Phone).HasMaxLength(10);
            builder.Property(x => x.Address).HasMaxLength(100);
        }
    }
}
