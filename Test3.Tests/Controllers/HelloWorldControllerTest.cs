using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using Test3.Controllers;

namespace Test3.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HelloWorldController();

            // Act
            var result = controller.Index() as ContentResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello world", result.Content);
        }
    }
}
