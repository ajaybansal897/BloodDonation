using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BloodDonation.Controllers
{
    public class AppointmentsController : Controller
    {
        private IConfiguration _configuration;
        private BookingHandler bookingHandler;

        public AppointmentsController(IConfiguration configuration)
        {
            _configuration = configuration;
            bookingHandler = new BookingHandler(_configuration);
        }

        public IActionResult Index()
        {
            var bookings = bookingHandler.GetBookings();
            return View(bookings);
        }

        [HttpGet()]
        public IActionResult Search(int refer)
        {
            var bookings = bookingHandler.GetBookingById(refer);
            ViewBag.refer = refer;
            return View("Index",bookings);

        }
    }
}