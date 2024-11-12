using eTransport.Models;
using Microsoft.EntityFrameworkCore;

namespace eTransport.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
     
            modelBuilder.Entity<SoferiServicii>().HasKey(ss => new
            {
                ss.SoferId,
                ss.ServiciuId
            });
            
            modelBuilder.Entity<SoferiServicii>().HasOne(s => s.Serviciu).WithMany(ss => ss.SoferiServicii).HasForeignKey(s => s.ServiciuId);

            modelBuilder.Entity<SoferiServicii>().HasOne(s => s.Sofer).WithMany(ss => ss.SoferiServicii).HasForeignKey(s => s.SoferId);

            
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Sofer>Soferi {  get; set; }
        public DbSet<Serviciu> Servicii { get; set; }
        public DbSet<SoferiServicii> SoferiServicii { get; set; }
        public DbSet<Locatie> Locatii{ get; set; }
        public DbSet<MarcaUtilaj> MarciUtilaje { get; set; }

    }
}
