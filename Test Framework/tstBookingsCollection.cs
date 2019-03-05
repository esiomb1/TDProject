using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstBookingsCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsBookingsCollection AllBookings = new clsBookingsCollection();
            //test to see if the class exists
            Assert.IsNotNull(AllBookings);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clsBookingsCollection AllBookings = new clsBookingsCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 0;
            //asig the data to the property
            AllBookings.Count = SomeCount;
            // test to see if the values are the same 
            Assert.AreEqual(AllBookings.Count, SomeCount);
        }

        [TestMethod]
        public void AllBookingsOk()
        {
            //create an instance of the class we want to create
            clsBookingsCollection Bookings = new clsBookingsCollection();
            //create some test data to assign to the property
            //in this case the data will be a list of objects
            List<clsBookings> TestList = new List<clsBookings>();
            //add an item to the list
            //create the item of test data
            clsBookings TestItem = new clsBookings();
            //set its properties
            TestItem.BookingNo = 4375;
            TestItem.CustomerNo = 2352;
            TestItem.FirstName = "John";
            TestItem.LastName = "Make";
            TestItem.Address = " 11 donald Road";
            TestItem.PostCode = " KT6 8RJ";
            TestItem.CardNo = "1234567891234568";
            TestItem.ExpiryDate = "07838774833";
            TestItem.CVSNo = "564";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Bookings.AllBookings = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Bookings.AllBookings, TestList);
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

