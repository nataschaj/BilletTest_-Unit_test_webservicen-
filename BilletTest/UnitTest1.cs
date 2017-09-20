using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1"))
            {
                //Arrange
                //Act
                var pris = client.GetBilPris();
                //Assert
                Assert.AreEqual(240, pris);
            }
        }
    }
}
