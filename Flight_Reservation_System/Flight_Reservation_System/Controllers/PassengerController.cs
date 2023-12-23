using Flight_Reservation_System.Data;
using Flight_Reservation_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flight_Reservation_System.Controllers
{
    public class PassengerController : Controller
    {
        static public List<Passenger> Passengers = new List<Passenger>();

        private readonly FlightDbContext _context;

        public PassengerController(FlightDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var passengers = _context.Passengers.ToList();
            return View(passengers);
        }
    }
}
