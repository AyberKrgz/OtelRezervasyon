namespace HotelReservationApp.Models
{
    public class Hotel
    {
        public int Id { get; set; }               // Otele ait benzersiz kimlik
        public string Name { get; set; }          // Otelin adı
        public string Location { get; set; }      // Otelin konumu (şehir, bölge, vb.)

        // Rezervasyonları temsil eden ilişki
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();  // Koleksiyon başlatıldı
    }
}
