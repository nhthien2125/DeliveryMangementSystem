using DeliveryMangementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryMangementSystem._1.Models_Configer
{
    class CustomerConfig : IEntityTypeConfiguration<CUSTOMER>
    {
        public void Configure(EntityTypeBuilder<CUSTOMER> builder)
        {
            builder.ToTable("CUSTOMER");
            builder.HasKey(x => x.Customer_ID);

            builder.Property(x => x.Customer_ID).HasMaxLength(10);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(10);

            builder.HasMany(x => x.Orders)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.Customer_ID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
