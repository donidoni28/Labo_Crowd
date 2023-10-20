using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.DataAccess.Configs
{
    internal class CounteprartyConfig : IEntityTypeConfiguration<CounterpartyEntity>
    {
        public void Configure(EntityTypeBuilder<CounterpartyEntity> builder)
        {
            builder.ToTable("Counterparty");

            builder.HasKey(i => i.IdCounterparty)
                .IsClustered();

            builder.Property(a => a.Amount)
                .HasColumnType("money");

            builder.Property(d => d.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(300);
        }
    }
}
