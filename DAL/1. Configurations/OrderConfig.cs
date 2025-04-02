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
    class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("xORDER");
            builder.HasKey(x => x.Order_ID);
            builder.Property(x => x.Branch_ID).HasMaxLength(10);
            builder.Property(x => x.Customer_ID).HasMaxLength(10);
            builder.Property(x => x.Shipper_ID).HasMaxLength(10);
            builder.Property(x => x.Order_Date).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Payment_Method).IsRequired();
            builder.Property(x => x.Total_Amount).IsRequired();

            builder.HasOne(x => x.Branch).WithMany(x => x.Orders).HasForeignKey(x => x.Branch_ID);
            builder.HasOne(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.Customer_ID);
            builder.HasOne(x => x.Shipper).WithMany(x => x.Orders).HasForeignKey(x => x.Shipper_ID);

        }
    }
}
