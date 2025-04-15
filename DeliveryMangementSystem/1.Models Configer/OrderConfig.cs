using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMangementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryMangementSystem._1.Models_Configer
{
    class OrderConfig : IEntityTypeConfiguration<ORDER>
    {
        public void Configure(EntityTypeBuilder<ORDER> builder)
        {
            builder.ToTable("xORDER");
            builder.HasKey(o => o.Order_ID);

            builder.Property(o => o.Order_ID).HasMaxLength(10);
            builder.Property(o => o.Customer_ID).IsRequired().HasMaxLength(10);
            builder.Property(o => o.Shipper_ID).IsRequired(false).HasMaxLength(10);
            builder.Property(o => o.Branch_ID).IsRequired(false).HasMaxLength(10);
            builder.Property(o => o.Status).IsRequired();
            builder.Property(o => o.Payment_Method).IsRequired();
            builder.Property(o => o.OrderDate).IsRequired();
            builder.Property(o => o.Delivery_Date).IsRequired(false);
            builder.Property(o => o.Total_Amount).IsRequired();

            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.Customer_ID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Shipper)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.Shipper_ID)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(o => o.Branch)
                .WithMany(b => b.Orders)
                .HasForeignKey(o => o.Branch_ID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
