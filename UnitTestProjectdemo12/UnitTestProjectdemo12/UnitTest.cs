
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectdemo12
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.Equals(true, true);
               
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.Equals(true, false);

        }
    }
}
