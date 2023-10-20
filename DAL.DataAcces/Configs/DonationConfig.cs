using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.DataAccess.Configs
{
    internal class DonationConfig : IEntityTypeConfiguration<DonationEntity>
    {
        public void Configure(EntityTypeBuilder<DonationEntity> builder)
            {
                builder.HasKey(keys => new { keys.IdUser, keys.IdProject });

                builder.HasOne(u => u.User)
                    .WithMany(p => p.Donations)
                    .HasForeignKey(fk => fk.IdUser)
                    .OnDelete(DeleteBehavior.NoAction);

                builder.HasOne(p => p.Project)
                    .WithMany(u => u.Donators)
                    .HasForeignKey(fk => fk.IdProject)
                    .OnDelete(DeleteBehavior.NoAction);

                builder.Property(a => a.Amount)
                    .HasColumnType("money");

                builder.Property(d => d.DateOfDonation)
                    .HasColumnType("date")
                    .HasDefaultValue(DateTime.UtcNow);


            }
        
    }
}
