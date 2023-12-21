using Flight_Reservation_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Flight_Reservation_System.Controllers
{
    public class AdminController : Controller
    {
        private AgencyContext _context;
        public AdminController(AgencyContext wsc)
        {
            _context = wsc;
        }
        [Authorize(Roles = "Admin")]
        //public IActionResult Index()
        //{
        //    Admin admin = new Admin();
        //    admin.toursCount = _context.Tours.Count();
        //    admin.countriesCount = _context.Countries.Count();
        //    admin.passengersCount = _context.Users.Count();
        //    admin.citiesCount = _context.Cities.Count();
        //    return View(admin);
        //}
    }
}