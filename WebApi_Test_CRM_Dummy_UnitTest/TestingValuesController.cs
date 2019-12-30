using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using WebApi_Test_CRM_Dummy.Controllers;
using WebApi_Test_CRM_Dummy.Models;

namespace WebApi_Test_CRM_Dummy_UnitTest
{
    [TestClass]
   public class TestingValuesController
    {
        [TestMethod]
        public void ShouldGetValues()
        {
          List<string> stringTest = new List<string>{ "value1", "value2" };
            var controller = new ValuesController();

            var result = controller.Get() as List<string>;
            Assert.AreEqual(result.Count, stringTest.Count);
        }

        [TestMethod]
        public void ShouldGetById()
        {
            
            var controller = new ValuesController();

            var result = controller.Get(1) as string;
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void GetBookById()
        {
            var listBooks = GetBooks();
            var controller = new ValuesController(GetBooks());
            var result = controller.GetBook(1) as OkNegotiatedContentResult<Books>;
            Assert.IsNotNull(result);
            Assert.AreEqual(listBooks[0].Name, result.Content.Name);
        }

        [TestMethod]
        public void ShouldNotFindBook()
        {
            
            var controller = new ValuesController(GetBooks());
            var result = controller.GetBook(100);

            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        private List<Books> GetBooks()
        {
            var bookList = new List<Books>();
            bookList.Add(new Books { Id = 1, Name = "Padre Rico", Year = 1984 });
            bookList.Add(new Books { Id = 2, Name = "Dog Shoe", Year = 2017 });
            bookList.Add(new Books { Id = 3, Name = "1984", Year = 1945 });
            return bookList;
        }
    }
}
