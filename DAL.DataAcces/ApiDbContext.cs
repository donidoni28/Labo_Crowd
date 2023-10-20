
using DAL.DataAccess.Configs;
using DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataAccess
{
    public class ApiDbContext : DbContext
    {
        private readonly string _cnstr;

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<CounterpartyEntity> CounterParties { get; set; }



        public ApiDbContext()
        {
            this._cnstr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApiCrowd;Integrated Security=True;Connect Timeout=60";
        }
        public ApiDbContext(string cnstr)
        {
            this._cnstr = cnstr;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_cnstr);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<UserEntity>(new UserConfig());
            modelBuilder.ApplyConfiguration<ProjectEntity>(new ProjectConfig());
            modelBuilder.ApplyConfiguration<CounterpartyEntity>(new CounteprartyConfig());
            modelBuilder.ApplyConfiguration<ParticipationEntity>(new ParticipationConfig());
            modelBuilder.ApplyConfiguration<DonationEntity>(new DonationConfig());

            base.OnModelCreating(modelBuilder);
        }
    }

}