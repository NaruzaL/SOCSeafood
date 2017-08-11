using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SOCSeafood.Controllers;
using SOCSeafood.Models;
using Xunit;
namespace SOC.Tests.ControllerTests
{
    public class HomeControllerTest
    {
        [Fact]
        public void Get_ViewResult_Signup_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
