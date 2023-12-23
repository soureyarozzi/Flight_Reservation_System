using Flight_Reservation_System.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Flight_Reservation_System.Controllers
{
    public class AdminController : Controller
    {
        private readonly FlightDbContext _context;
        public IActionResult Index()
        {
            return View();
        }

        public AdminController(FlightDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ManageFlights()
        {
            var flights = _context.Flights.ToList();
            return View(flights);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ManagePassengers()
        {
            var passengers = _context.Passengers.ToList();
            return View(passengers);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ManagePlanes()
        {
            var planes = _context.AirPlanes.ToList();
            return View(planes);
        }

    }
}
