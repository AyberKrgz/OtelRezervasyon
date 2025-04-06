using Microsoft.EntityFrameworkCore;
using HotelReservationApp.Models;  // Hotel ve Reservation model dosyasına erişim sağlamak için

namespace HotelReservationApp.Data  // Data namespace
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Veritabanı tabloları
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        // Veritabanı modelini yapılandırma
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
