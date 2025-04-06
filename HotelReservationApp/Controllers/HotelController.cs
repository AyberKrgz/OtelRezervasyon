using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelReservationApp.Models;
using HotelReservationApp.Data;  // ApplicationDbContext'in bulunduğu namespace


namespace HotelReservationApp.Controllers
{
    public class HotelController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor - Veritabanı bağlantısı
        public HotelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Otel listesini görüntüle
        public async Task<IActionResult> Index()
        {
            var hotels = await _context.Hotels.ToListAsync();
            return View(hotels);  // Hotels listesi View'a gönderilir
        }

        // Otel detaylarını görüntüle
        public async Task<IActionResult> Details(int id)
        {
            var hotel = await _context.Hotels
                .Include(h => h.Reservations) // Otelin rezervasyonlarını da dahil et
                .FirstOrDefaultAsync(h => h.Id == id);

            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);  // Otel ve ilgili rezervasyonlar view'a gönderilir
        }
    }
}
