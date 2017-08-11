using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOCSeafood.Models;
using Xunit;

namespace SOC.Tests.NewsletterTests
{
    public class NewsletterTest
    {
        [Fact]
        public void GetInterestTest()
        {
            //Arrange
            var newsletter = new Newsletter();
            newsletter.Interest = "Shellfish";

            //Act
           
            var result = newsletter.Interest;

            //Assert
            Assert.Equal("Shellfish", result);
        }
    }
}
