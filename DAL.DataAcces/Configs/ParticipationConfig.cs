using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.DataAccess.Configs
{
    internal class ParticipationConfig : IEntityTypeConfiguration<ParticipationEntity>
    {
        public void Configure(EntityTypeBuilder<ParticipationEntity> builder)
        {
            builder.ToTable("Users_Counterparties");

            builder.HasKey(keys => new { keys.IdUser, keys.IdCounterparty })
                .IsClustered();

            builder.HasOne(u => u.User)
                .WithMany(p => p.Participations)
                .HasForeignKey(fk => fk.IdUser)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.CounterParty)
                .WithMany(u => u.Contributors)
                .HasForeignKey(fk => fk.IdCounterparty)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(d => d.DateOfParticipation)
                .HasColumnType("date")
                .HasDefaultValue(DateTime.UtcNow);


        }

    }
}
