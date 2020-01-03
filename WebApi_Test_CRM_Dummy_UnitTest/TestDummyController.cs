using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi_Test_CRM_Dummy.Controllers;

namespace WebApi_Test_CRM_Dummy_UnitTest
{
    /// <summary>
    /// Test sobre Dummy Controller
    /// </summary>
    [TestClass]
    public class TestDummyController
    {
        
        

        [TestMethod]
        public void ShouldGetEmployees()
        {

            //AAA

            //Arrange
            DummyController controller = new DummyController();

            //Act
            object result = controller.Get();
            //Assert
            Assert.IsNotNull(result);


        }
    }
}
