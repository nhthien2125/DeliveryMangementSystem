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
    class ShipperConfig : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.ToTable("SHIPPER");
            builder.HasKey(x => x.Shipper_ID);
            builder.Property(x => x.Shipper_ID).HasMaxLength(10);
            builder.Property(x => x.Phone).HasMaxLength(10);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Email).HasMaxLength(100);
        }
    }
}
