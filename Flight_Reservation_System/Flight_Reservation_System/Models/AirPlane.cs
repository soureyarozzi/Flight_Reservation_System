using System.ComponentModel.DataAnnotations;

namespace Flight_Reservation_System.Models
{
    public class AirPlane
    {
        [Key]
        [Required]
        public int PlaneId { get; set; }
        public string PlaneName { get; set; }
        public int Capacity { get; set; }
        
        public ICollection<Flights>? Flights { get; set; }//Navigation her Flights birden fazla Airplani olabilir

    }
}
