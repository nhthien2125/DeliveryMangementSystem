using DeliveryMangementSystem.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DAL._1._Configurations
{
    public class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("ACCOUNT");
            builder.HasKey(x => x.Account_ID);
            builder.Property(x => x.Account_ID).HasMaxLength(10);
            builder.Property(x => x.Username).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Role).IsRequired();

            builder.HasOne(x => x.Shipper)
                   .WithOne(x => x.Account)
                   .HasForeignKey<Account>(x => x.Shipper_Id)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
