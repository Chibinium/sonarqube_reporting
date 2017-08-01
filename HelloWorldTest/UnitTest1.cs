using HelloWorld;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void passHelloWorld()
        {
            string actual = "HelloWorld!";
            Assert.AreEqual(HelloTest.HelloWorld.returnHelloWorld(), actual);
        }

        [TestMethod()]
        public void failBizarroWorld()
        {
            string actual = "Bizarro World!";
            Assert.AreNotEqual(HelloTest.HelloWorld.returnHelloWorld(), actual);
        }
    }
}
