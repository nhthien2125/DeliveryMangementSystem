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
    class BranchConfig : IEntityTypeConfiguration<BRANCH>
    {
        public void Configure(EntityTypeBuilder<BRANCH> builder)
        {
            builder.ToTable("BRANCH");
            builder.HasKey(x => x.Branch_ID);

            builder.Property(x => x.Branch_ID).HasMaxLength(10);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100);

            builder.HasMany(x => x.Orders)
                .WithOne(x => x.Branch)
                .HasForeignKey(x => x.Branch_ID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
