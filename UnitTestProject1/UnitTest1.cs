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
            _p = new Person("010190-1235", "Magne");
        }

        [TestMethod]
        public void TestAdult()
        {
            // Under 18 should return false
            _p.Age = (decimal)17.99;
            bool result = _p.isAdult();
            Assert.IsFalse(result);

            // Equal to 18 should return true
            _p.Age = (decimal)18.00;
            result = _p.isAdult();
            Assert.IsTrue(result);

            // Over 18 should return true
            _p.Age = (decimal)18.01;
            result = _p.isAdult();
            Assert.IsTrue(result);
        }





        [TestMethod]
        public void TestInEquality()
        {
            Person p = new Person();
            p.Name = "Bjarne";
            p.SSN = "010190-1235";
            p.Age = 24;

            Person otherP = new Person("010190-1235", "Børge");
            otherP.Age = 24;

            Assert.AreNotEqual(p, otherP);
        }


        [TestMethod]
        public void TestEqual()
        {
            Person p = new Person();
            p.Name = "Bjarne";
            p.SSN = "010190-1235";
            p.Age = 24;

            Person otherP = new Person();
            otherP.Name = "Bjarne";
            otherP.SSN = "010190-1235";
            otherP.Age = 24;

            Assert.AreEqual(p, otherP);
        }

        [TestMethod]
        public void TestAgeException()
        {
            Person p = new Person();
            p.Name = "Bjarne";
            p.SSN = "010190-1235";

            p.Age = -35;

            try
            {
                p.Age = -24;
                Assert.Fail();
            }
            catch (AgeException ae)
            {
                Assert.AreEqual("Alder for lav", ae.Message);
            }
            catch (Exception e)
            {
               Assert.Fail();
            }


        }
    }
}
