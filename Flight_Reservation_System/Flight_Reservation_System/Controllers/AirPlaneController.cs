using Flight_Reservation_System.Data;
using Flight_Reservation_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Flight_Reservation_System.Controllers
{
    public class AirPlaneController : Controller
    {
        static public List<AirPlane> airplanes = new List<AirPlane>();

        private readonly FlightDbContext _context;

        public AirPlaneController(FlightDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var airplanes = _context.AirPlanes.ToList();
            return View(airplanes);
        }
    }
}
