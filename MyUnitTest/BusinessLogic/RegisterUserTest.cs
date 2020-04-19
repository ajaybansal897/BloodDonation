using ClassLibrary.BusinessLogic;
using CommonModels;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyUnitTest.BusinessLogic
{
    [TestFixture]
    public class RegisterUserTest
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
        public void When_NewUser_Registers()
        {
            //Arrange
            User user = new User()
            {
                First_Name = "F Testing",
                Last_Name = "L Testing",
                Address = "123 Street Canada",
                Gender = "Male",
                Phone = "78787878787",
                Password = "12345678",
                ConfirmPassword = "12345678",
                Email = "email@gmail.com",
                Age = 18,
                User_Type = "Donar",
                Postal_Code = "AB1234",
                DOB = DateTime.Parse("19-12-1994")
            };
            UserHandler userHandler = new UserHandler(configuration);

            //Act
            var result = userHandler.CreateUser(user);

            //Assert
            Assert.Greater(result, 1);
        }


        [Test]
        public void When_UserReviewed_Booking()
        {
            //Arrange
            Booking booking = new Booking()
            {
                Timing = DateTime.Parse("01-05-2020 05:30PM"),
                Center_id = 2,
                User_id = 2,
            };
            BookingHandler bookingHandler = new BookingHandler(configuration);

            //Act
            var result = bookingHandler.AddBooking(booking);

            //Assert
            Assert.Greater(result,1);

        }

    }
}
