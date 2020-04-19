using CommonModels;
using DataAccessLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.BusinessLogic
{
    public class BookingHandler
    {
        private IConfiguration _configuration;
        DbBookingHandler data;

        public BookingHandler(IConfiguration configuration)
        {
            _configuration = configuration;
            data = new DbBookingHandler(_configuration);
        }

        public int AddBooking(Booking booking)
        {
            return data.AddBookingDB(booking);
        }

        public List<Booking> GetBookings()
        {
            return data.GetBookings();
        }

        public List<Booking> GetBookingById(int refer)
        {
            return data.GetBookingById(refer);
        }
    }
}
