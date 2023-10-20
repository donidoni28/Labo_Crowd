using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.DataAccess.Configs
{
    internal class ProjectConfig : IEntityTypeConfiguration<ProjectEntity>
    {
        public void Configure(EntityTypeBuilder<ProjectEntity> builder)
        {
            builder.ToTable("Project");

            builder.HasKey(i => i.IdProject)
                .IsClustered();

            builder.Property(n => n.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.Property(a => a.Amount)
                .IsRequired()
                .HasColumnType("money");

            builder.Property(c => c.CreatedAt)
                .HasColumnType("Date")
                .HasDefaultValueSql("getdate()");

            builder.Property(e => e.EndDate)
                .HasColumnType("Date");

            builder.Property(p => p.PublishDate)
                .HasColumnType("Date");

            builder.HasMany(p => p.Counterparties)
                .WithOne(c => c.Project)
                .HasForeignKey(fk => fk.IdProject)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
