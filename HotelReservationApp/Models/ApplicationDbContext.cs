using Microsoft.EntityFrameworkCore;

namespace HotelReservationApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Hotel, Reservation gibi modelleri burada ekleyeceğiz
    }
}
