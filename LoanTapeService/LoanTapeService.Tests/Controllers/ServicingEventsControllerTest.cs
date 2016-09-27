using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoanTapeService;
using LoanTapeService.Controllers;
using LoanTapeService.Models;
using LoanTapeService.Services;
using Moq;

namespace LoanTapeService.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            var servicingEventService = new Mock<IServicingEventService>();

            var notificationService = new Mock<INotificationService>();
            var  servicingController = new ServicingEventsController(servicingEventService.Object, notificationService.Object);

            //Act
            var result = servicingController.Get(1);
            var servicingResult = result as NegotiatedContentResult<IEnumerable<ServicingEvent>>;
           
            //Assert
            Assert.IsInstanceOfType(result, typeof(OkResult));
            Assert.AreEqual(1,servicingResult.Content.Count());
        }



        [TestMethod]
        public void Put()
        {
           // Arrange
           //ValuesController controller = new ValuesController();

           // Act
           // controller.Post("value");

           // Assert
        }

    }
}
