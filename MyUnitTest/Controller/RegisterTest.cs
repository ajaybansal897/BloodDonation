using BloodDonation.Controllers;
using CommonModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyUnitTest.Controller
{
    [TestFixture]
    public class RegisterTest
    {
        RegisterController rc;

        [SetUp]
        public void Setup()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            // Duplicate here any configuration sources you use.
            configurationBuilder.AddJsonFile("appsettings.json");
            IConfiguration configuration = configurationBuilder.Build();

            rc = new RegisterController(configuration);
        }

        [Test]
        public void When_UserIsRegistered_SelectCenter()
        {
            //Act
            ViewResult result = rc.SelectCenter() as ViewResult;

            //Asset
            Assert.IsNotNull(result.ViewData);
           
        }


    }
}
