using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBilPris()
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

        [TestMethod]
        public void TestMCPris()
        {
            using (var client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1"))
            {
                //Arrange
                //Act
                var pris = client.GetMCPris();
                //Assert
                Assert.AreEqual(125, pris);
            }
        }
    }
}
