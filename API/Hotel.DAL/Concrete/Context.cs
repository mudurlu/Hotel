using Hotel.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Hotel.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDb;Database=HotelDb;Trusted_Connection=True; integrated security= true");
        }
        public DbSet<Bulten> Bultenler { get; set; }
        public DbSet<Hizmet> Hizmetler { get; set; }
        public DbSet<Oda> Odalar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Referans> Referanslar { get; set; }

    }
}
