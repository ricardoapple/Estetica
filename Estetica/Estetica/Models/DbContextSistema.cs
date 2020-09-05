using Microsoft.EntityFrameworkCore;

namespace Estetica.Models
{
    public class DbContextSistema : DbContext
    {
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Town> Town { get; set; }




        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {

        }

        public DbContextSistema()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasKey(c => c.IdCountry);
            modelBuilder.Entity<Province>().HasMany(c => c.Countries).WithOne().HasForeignKey(c => c.IdCountry).IsRequired();
            modelBuilder.Entity<Town>().HasMany(c => c.Provinces).WithOne().HasForeignKey(c => c.IdProvince).IsRequired();
        }

    }
}
