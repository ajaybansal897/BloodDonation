using CommonModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using System.Globalization;
using System.Linq;

namespace DataAccessLayer
{
    public class DbBookingHandler
    {
        private IConfiguration _configuration;
        private readonly string DbConnectionString = "DefaultConnection";

        public DbBookingHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int AddBookingDB(Booking booking)
        {
            String dt = booking.Timing.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            string query = "INSERT INTO Bookings (User_id,Center_id,Timing) VALUES ('" + booking.User_id + "','" + booking.Center_id + "','" + dt + "'); SELECT SCOPE_IDENTITY()";
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbHelper.BlogConnectionStringValue(_configuration, DbConnectionString)))
            {
                return connection.Query<int>(query).Single();
            }
        }


        public List<Booking> GetBookings()
        {
            List<Booking> bookings = null;
            string query = "SELECT Bookings.*,Centers.Address AS Center_Address,Users.First_Name,Users.Last_Name FROM Bookings INNER JOIN Centers ON Bookings.Center_id=Centers.Id INNER JOIN Users ON Bookings.User_id=Users.Id";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbHelper.BlogConnectionStringValue(_configuration, DbConnectionString)))
            {
                bookings = connection.Query<Booking>(query).ToList();
            }
            return bookings;
        }

        public List<Booking> GetBookingById(int id)
        {
            List<Booking> bookings = null;
            string query = "SELECT Bookings.*,Centers.Address AS Center_Address,Users.First_Name,Users.Last_Name FROM Bookings INNER JOIN Centers ON Bookings.Center_id=Centers.Id INNER JOIN Users ON Bookings.User_id=Users.Id WHERE Bookings.Id='"+id+"'";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbHelper.BlogConnectionStringValue(_configuration, DbConnectionString)))
            {
                bookings = connection.Query<Booking>(query).ToList();
            }
            return bookings;
        }
    }
}
