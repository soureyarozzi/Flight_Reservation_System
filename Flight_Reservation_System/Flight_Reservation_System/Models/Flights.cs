using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flight_Reservation_System.Models
{
    public class Flights
    {
        [Key]
        [Required]
        public int FlightId { get; set; }
        public string ?Destination { get; set; }
        public DateTime DepartureDate { get; set; }

        public int AvailableSeats { get; set; }
        [Required]
        [ForeignKey("PlaneId")]
        public int PlaneId { get; set; }
        public AirPlane ?AirPlane { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }//Navigation her Reservation birden fazla Flighti olabilir

    }
}
