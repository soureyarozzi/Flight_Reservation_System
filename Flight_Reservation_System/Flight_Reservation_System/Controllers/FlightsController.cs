using Flight_Reservation_System.Data;
using Flight_Reservation_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flight_Reservation_System.Controllers
{
    public class FlightsController : Controller
    {
        static public List<Flights> flights = new List<Flights>();

        private readonly FlightDbContext _context;

        public FlightsController(FlightDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var flights = _context.Flights.ToList();
            return View(flights);
        }
    }
}
