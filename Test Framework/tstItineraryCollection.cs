using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test_Framework
{
    [TestClass]
    public class tstItineraryCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsItineraryCollection AllItineries = new clsItineraryCollection();
            //test to see if the class exists
            Assert.IsNotNull(AllItineries);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clsItineraryCollection AllItineraries = new clsItineraryCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 72;
            //asig the data to the property
            AllItineraries.Count = SomeCount;
            // test to see if the values are the same 
            Assert.AreEqual(AllItineraries.Count, SomeCount);
        }

        [TestMethod]
        public void AllCustomersOk()
        {
            //create an instance of the class we want to create
            clsItineraryCollection Itineraries = new clsItineraryCollection();
            //create some test data to assign to the property
            //in this case the data will be a list of objects
            List<clsItinerary> TestList = new List<clsItinerary>();
            //add an item to the list
            //create the item of test data
            clsItinerary TestItem = new clsItinerary();
            //set its properties
            TestItem.ItineraryNo = 4375;
            TestItem.CustomerNo = 4545;
            TestItem.BookingNo = 4634656;
            TestItem.DepartureFlightNo = 435345;
            TestItem.ArrivalFlightNo = 345435;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Itineraries.AllItineraries = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Itineraries.AllItineraries, TestList);
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
