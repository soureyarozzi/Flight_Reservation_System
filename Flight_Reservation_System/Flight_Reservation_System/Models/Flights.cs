using System.ComponentModel.DataAnnotations;

namespace Flight_Reservation_System.Models
{
    public class Flights
    {
        [Key]
        public int FlightId { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public int AvailableSeats { get; set; }
    }
}
