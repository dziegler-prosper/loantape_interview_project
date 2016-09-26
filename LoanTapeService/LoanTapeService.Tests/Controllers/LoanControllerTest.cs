using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanTapeService.Controllers;
using LoanTapeService.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoanTapeService.Tests.Controllers
{
    [TestClass]
    public class LoanControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            LoanTapeController controller = new LoanTapeController();

            // Act
            IEnumerable<LoanTapeModel> result = controller.GetAllLoans();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

 
    }
}
