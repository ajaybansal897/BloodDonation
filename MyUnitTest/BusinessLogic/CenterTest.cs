using ClassLibrary.BusinessLogic;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyUnitTest.BusinessLogic
{
    [TestFixture]
    public class CenterTest
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
        public void When_RequestFor_CenterDetails()
        {
            //Arrange
            CentreHandler centre = new CentreHandler(configuration);


            //Act
            var result = centre.GetCenterDetails(3);

            //Assert
            Assert.IsNotNull(result);

        }


        [Test]
        public void When_RequestFor_AllCenters()
        {
            //Arrange
            CentreHandler centre = new CentreHandler(configuration);


            //Act
            var result = centre.GetAllCentres();

            //Assert
            Assert.IsNotNull(result);

        }
    }
}
