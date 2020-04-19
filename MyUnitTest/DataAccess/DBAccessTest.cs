using DataAccessLayer;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyUnitTest.DataAccess
{
    [TestFixture]
    public class DBAccessTest
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
        public void When_RequestFor_UserDetails()
        {
            //Arrange
            DbUserHelper helper = new DbUserHelper(configuration);

            //Act
            var result = helper.GetUserDetailsDB(17);

            //Assert
            Assert.IsNotNull(result);
        }

    }
}
