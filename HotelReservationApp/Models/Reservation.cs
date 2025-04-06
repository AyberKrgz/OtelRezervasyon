namespace HotelReservationApp.Models
{
    public class Reservation
    {
        public int Id { get; set; }                // Rezervasyonun benzersiz kimliği
        public int HotelId { get; set; }           // Hangi otelde yapıldığını belirten anahtar
        public DateTime StartDate { get; set; }    // Rezervasyonun başlangıç tarihi
        public DateTime EndDate { get; set; }      // Rezervasyonun bitiş tarihi
        public string CustomerName { get; set; }   // Müşterinin adı

        // İlişkilendirilmiş Otel nesnesi
        public Hotel Hotel { get; set; } = new Hotel(); // Hotel nesnesi başlatıldı
    }
}
