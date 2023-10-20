using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.DataAccess.Configs
{
    internal class UserConfig : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(i => i.IdUser)
                .IsClustered();

            builder.Property(f => f.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.Property(l => l.LastName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.HasIndex(e => e.Email)
                .IsUnique();

            builder.Property(E => E.Email)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(254);

            builder.Property(p => p.Password)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(512);

            builder.HasMany(p => p.Projects)
                .WithOne(o => o.ProjectOwner)
                .HasForeignKey(fk => fk.IdProjectOwner)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }
}
