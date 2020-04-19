using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClassLibrary.BusinessLogic;
using CommonModels;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace BloodDonation.Controllers
{
    public class RegisterController : Controller
    {

        private IConfiguration _configuration;
        UserHandler handler;

        public RegisterController(IConfiguration configuration)
        {
            _configuration = configuration;
            handler = new UserHandler(_configuration);
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                int id = handler.CreateUser(user);
                HttpContext.Session.SetString("user_id", id.ToString());
                return RedirectToAction("SelectCenter");
            }
            return View("Index");
        }

        
        public IActionResult SelectCenter()
        {
            CentreHandler handler = new CentreHandler(_configuration);
            var centres = handler.GetAllCentres();
            return View(centres);
        }


        [HttpPost]
        public IActionResult Review(IFormCollection collection)
        {
            if(HttpContext.Session.GetString("user_id")==null)
            {
                return RedirectToAction("Index");
            }

            String dt = collection["timing"];
            DateTime theDate = DateTime.ParseExact(dt.Replace('T', ' '), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            dt = theDate.ToString("dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture);
            
            UserHandler handler = new UserHandler(_configuration);
            User user = handler.GetUserDetails(int.Parse(HttpContext.Session.GetString("user_id")));

            CentreHandler handler1 = new CentreHandler(_configuration);
            Centre centre = handler1.GetCenterDetails(int.Parse(collection["center_id"]));

            ViewBag.Center = centre.Address;
            ViewBag.Center_id = centre.Id;
            ViewBag.Timing = dt;

            return View(user);
        }

        [HttpPost]
        public IActionResult Booking(IFormCollection collection)
        {
            Booking booking = new Booking();
            booking.Center_id = int.Parse(collection["center_id"]);
            booking.User_id = int.Parse(collection["user_id"]);

            DateTime theDate1 = DateTime.ParseExact(collection["timing"], "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture);
            booking.Timing = theDate1;

            BookingHandler bookingHandler = new BookingHandler(_configuration);
            ViewBag.refer = bookingHandler.AddBooking(booking);

            HttpContext.Session.Remove("user_id");
            return View();
        }
    }

}
