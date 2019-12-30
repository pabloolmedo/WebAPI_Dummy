using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi_Test_CRM_Dummy.Controllers;
using WebApi_Test_CRM_Dummy.Models;

namespace WebApi_Test_CRM_Dummy_UnitTest
{
    [TestClass]
   public class TestSimpleWebApiController
    {
        [TestMethod]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new WebApi_UnitTestController(testProducts);

            var result = controller.GetAllProducts() as List<WebApi_Test>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public async Task GetAllProductsAsync_ShouldReturnAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new WebApi_UnitTestController(testProducts);

            var result = await controller.GetAllProductsAsync() as List<WebApi_Test>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public void GetProduct_ShouldReturnCorrectProduct()
        {
            var testProducts = GetTestProducts();
            var controller = new WebApi_UnitTestController(testProducts);

            var result = controller.GetProduct(4) as OkNegotiatedContentResult<WebApi_Test>;
            Assert.IsNotNull(result);
            Assert.AreEqual(testProducts[3].Name, result.Content.Name);
        }

        [TestMethod]
        public async Task GetProductAsync_ShouldReturnCorrectProduct()
        {
            var testProducts = GetTestProducts();
            var controller = new WebApi_UnitTestController(testProducts);

            var result = await controller.GetProductAsync(4) as OkNegotiatedContentResult<WebApi_Test>;
            Assert.IsNotNull(result);
            Assert.AreEqual(testProducts[3].Name, result.Content.Name);
        }

        [TestMethod]
        public void GetProduct_ShouldNotFindProduct()
        {
            var controller = new WebApi_UnitTestController(GetTestProducts());

            var result = controller.GetProduct(999);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }


        private List<WebApi_Test> GetTestProducts()
        {
            var testProducts = new List<WebApi_Test>();
            testProducts.Add(new WebApi_Test { Id = 1, Name = "Demo1", Price = 1 });
            testProducts.Add(new WebApi_Test { Id = 2, Name = "Demo2", Price = 3.75M });
            testProducts.Add(new WebApi_Test { Id = 3, Name = "Demo3", Price = 16.99M });
            testProducts.Add(new WebApi_Test { Id = 4, Name = "Demo4", Price = 11.00M });

            return testProducts;
        }
    }
}
