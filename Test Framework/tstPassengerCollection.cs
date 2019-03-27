using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test_Framework
{
    [TestClass]
    public class tstPassengerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsPassengerCollection AllPassengers = new clsPassengerCollection();
            //test to see if the class exists
            Assert.IsNotNull(AllPassengers);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clsPassengerCollection AllPassengers = new clsPassengerCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 0;
            //asig the data to the property
            AllPassengers.Count = SomeCount;
            // test to see if the values are the same 
            Assert.AreEqual(AllPassengers.Count, SomeCount);
        }

        [TestMethod]
        public void AllPassengersOk()
        {
            //create an instance of the class we want to create
            clsPassengerCollection Passengers = new clsPassengerCollection();
            //create some test data to assign to the property
            //in this case the data will be a list of objects
            List<clsPassenger> TestList = new List<clsPassenger>();
            //add an item to the list
            //create the item of test data
            clsPassenger TestItem = new clsPassenger();
            //set its properties
            TestItem.PassengerNo = 4375;
            TestItem.FirstName = "John";
            TestItem.LastName = "Make";
            TestItem.DOB = " 11 donald Road";
            TestItem.Nationality = " KT6 8RJ";
            TestItem.PassportNo = " exy7364";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Passengers.AllPassengers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Passengers.AllPassengers, TestList);
        }




        //[TestMethod]
        //public void TwoCustomersPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection Customers = new clsCustomerCollection();
        //    // test to see tht the two values are the same 
        //    Assert.AreEqual(Customers.Count, 2);

        //
    }



}
