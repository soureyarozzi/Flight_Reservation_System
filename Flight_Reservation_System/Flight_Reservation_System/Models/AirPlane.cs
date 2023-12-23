using System.ComponentModel.DataAnnotations;

namespace Flight_Reservation_System.Models
{
    public class AirPlane
    {
        [Key]
        public int PlaneId { get; set; }
        public int Capacity { get; set; }
    }
}
