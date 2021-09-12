using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;

namespace ProductUnitTest
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]

        public void IndexReturnsNotNull()
        {
            // Arrange
            var controller = new ProductController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result, "View is null");
        }
    }
}
