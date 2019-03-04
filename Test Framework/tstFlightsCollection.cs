using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test_Framework
{
    [TestClass]
    public class tstFlightsCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsFlightsCollection AllFlights = new clsFlightsCollection();
            //test to see if the class exists
            Assert.IsNotNull(AllFlights);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clsFlightsCollection AllFlights = new clsFlightsCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 1;
            //asig the data to the property
            AllFlights.Count = SomeCount;
            // test to see if the values are the same 
            Assert.AreEqual(AllFlights.Count, SomeCount);
        }

        [TestMethod]
        public void AllFlightsOk()
        {
            //create an instance of the class we want to create
            clsFlightsCollection Flights = new clsFlightsCollection();
            //create some test data to assign to the property
            //in this case the data will be a list of objects
            List<clsFlights> TestList = new List<clsFlights>();
            //add an item to the list
            //create the item of test data
            clsFlights TestItem = new clsFlights();
            //set its properties
            TestItem.FlightNo = 4375;
            TestItem.DepartureDate = Convert.ToDateTime("05/06/2019");
            TestItem.ArrivalDate = Convert.ToDateTime("05/06/2019");
            TestItem.DepartureDestination = "JFK International";
            TestItem.ArrivalDestination = "LHR";
            TestItem.DepartureTime = Convert.ToDateTime("12:00");
            TestItem.ArrivalTime = Convert.ToDateTime("22:00");
            TestItem.Duration = "6:00";
            TestItem.Cost = "456";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Flights.AllFlights = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Flights.AllFlights, TestList);
        }


        [TestMethod]
        public void  FindMethodOk()
        {
            //create an instance of the class we want to create
            clsFlightsCollection AllFlights = new clsFlightsCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 1;
            //asig the data to the property
            AllFlights.Count = SomeCount;
            // test to see if the values are the same 
            Assert.AreEqual(AllFlights.Count, SomeCount);
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

