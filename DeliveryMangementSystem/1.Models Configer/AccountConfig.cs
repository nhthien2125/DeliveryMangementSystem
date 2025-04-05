using DeliveryMangementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryMangementSystem._1.Models_Configer
{
    class AccountConfig : IEntityTypeConfiguration<ACCOUNT>
    {
        public void Configure(EntityTypeBuilder<ACCOUNT> builder)
        {
            builder.ToTable("ACCOUNT");
            builder.HasKey(x => x.Account_ID);


            builder.Property(x => x.Account_ID).HasMaxLength(10);
            builder.Property(x => x.Username).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Role).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.S_ID).HasMaxLength(10);

            builder.HasIndex(x => x.S_ID).IsUnique();

            builder.HasOne(x => x.Shipper)
                   .WithOne()
                   .HasForeignKey<ACCOUNT>(x => x.S_ID)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
