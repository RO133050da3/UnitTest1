using System;
//using ClassLibrary1;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    

    [TestClass]
    public class UnitTest1
    {
        private ClassLibrary1.Person _p;

        [TestInitialize]
        public void BeginTest()
        {
            _p = new Person();
            _p.Name = "Magne";
            _p.Age = 4;
        }

        [TestMethod]
        public void TestMethod1()
        {
            bool result = _p.isAdult();
            Assert.IsTrue(result);
        }
    }
}
