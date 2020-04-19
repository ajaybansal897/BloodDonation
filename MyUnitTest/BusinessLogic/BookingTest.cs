using ClassLibrary.BusinessLogic;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyUnitTest.BusinessLogic
{
    [TestFixture]
    public class BookingTest
    {

        IConfiguration configuration;

        [SetUp]
        public void Setup()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            // Duplicate here any configuration sources you use.
            configurationBuilder.AddJsonFile("appsettings.json");
            configuration = configurationBuilder.Build();
        }


        [Test]
        public void When_RequestFor_Appointments()
        {
            //Arrange
            BookingHandler bookingHandler = new BookingHandler(configuration);

            //Act
            var result = bookingHandler.GetBookings();

            //Asset
            Assert.IsNotNull(result);
        }


        [Test]
        public void When_RequestFor_Search_Appointment()
        {
            //Arrange
            BookingHandler bookingHandler = new BookingHandler(configuration);

            //Act
            var result = bookingHandler.GetBookingById(1010);

            //Asset
            Assert.IsNotNull(result);
        }
    }
}
