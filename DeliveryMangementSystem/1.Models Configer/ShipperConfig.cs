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
    class ShipperConfig : IEntityTypeConfiguration<SHIPPER>
    {
        public void Configure(EntityTypeBuilder<SHIPPER> builder)
        {
            builder.ToTable("SHIPPER");
            builder.HasKey(s => s.Shipper_ID);

            builder.Property(s => s.Shipper_ID).HasMaxLength(10);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
            builder.Property(s => s.Email).IsRequired().HasMaxLength(100);
            builder.Property(s => s.Phone).IsRequired().HasMaxLength(10);

            builder.HasMany(s => s.Orders)
                .WithOne(o => o.Shipper)
                .HasForeignKey(o => o.Shipper_ID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
