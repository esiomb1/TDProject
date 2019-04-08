using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //test to see that it exists
            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        public void CardNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //test to see it exists
            Int32 TestData = 1;
            //assign data to property
            APayment.CardNo = TestData;
            //test to see the two values are equal
            Assert.AreEqual(APayment.CardNo, TestData);
        }
        [TestMethod]
        public void CVVNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //test to see it exists
            Int32 TestData = 1;
            //assign data to property
            APayment.CVVNo = TestData;
            //test to see the two values are equal
            Assert.AreEqual(APayment.CVVNo, TestData);
        }
        [TestMethod]
        public void ExpiryDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create data
            DateTime TestData = DateTime.Now.Date;
            //assign data to property
            APayment.ExpiryDate = TestData;
            //test to see if the two are equal
            Assert.AreEqual(APayment.ExpiryDate, TestData);
        }
        [TestMethod]

        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment APayment = new clsPayment();
            //create data
            string TestData = "Email";
            //assign the data to the property
            APayment.Email = TestData;
            //test to see that the two values are eqaul
            Assert.AreEqual(APayment.Email, TestData);
        }
    }
    }


