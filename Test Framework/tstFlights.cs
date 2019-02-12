using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstFlights
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsFlights AFlight = new clsFlights();
            // test to see that it exists 
            Assert.IsNotNull(AFlight);
        }


        [TestMethod]
        //used to test the Flights property of the class
        public void FlightsPropertyOk()
        {
            //create an instance of the class
            clsFlights AFlight = new clsFlights();
            //create a variable to store the name of a county
            string SomeFlight;
            //assign a county to the variable
            SomeFlight = "Egypt";
            //try to send some data to the Customer property
            AFlight.Flight = SomeFlight;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AFlight.Flight, SomeFlight);
        }


        [TestMethod]
        //used to test the CustomerNo property of the class
        public void FlightNoPropertyOk()
        {
            //create an instance of the class
            clsFlights AFlight = new clsFlights();
            //create a variable to store the Id of a County
            Int32 FlightNo;
            //assign a value to the variable
            FlightNo = 1278793;
            //try to send some data to the CustomerNo property
            AFlight.FlightNo = FlightNo;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AFlight.FlightNo, FlightNo);
        }



        [TestMethod]
        //used to test the presence of the Valid Method
        public void Valid()
        {
            //create an instance of the class
            clsFlights AFlight = new clsFlights();
            //test to see if the valid method exists
            AFlight.Valid("barbados");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void FlightMinLessOne()
        {
            //create an instance of the class
            clsFlights AFlight = new clsFlights();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeFlight = "";
            Error = AFlight.Valid(SomeFlight);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void FlightMinBoundary()
        {
            //create an instance of the class
            clsFlights AFlight = new clsFlights();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeFlight = " b ";
            Error = AFlight.Valid(SomeFlight);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void FlightMaxPlusOne()
        {
            //create an instance of the class
            clsFlights AFlight = new clsFlights();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeFlight = " bgjhvjmhvfjhcgvhcnbvjhvmnvhvhvuyjhvfhfhyvgvycyfjgvuhcucjhvmhvhvhvhgv ";
            Error = AFlight.Valid(SomeFlight);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }




        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void FlightsMid()
        {
            //create an instance of the class
            clsFlights AFlight = new clsFlights();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeFlight = " bgjhvjmhvfjhcggv ";
            Error = AFlight.Valid(SomeFlight);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void FlightEtremeMax()
        {
            //create an instance of the class
            clsFlights AFlight = new clsFlights();
            //create a variable to record the result of the validation test
            String Error = "";
            //create test data t test method
            string SomeFlight = "";
            // create some test data to test the method 
            SomeFlight = SomeFlight.PadRight(500, 'a');
            // invoke the method
            Error = AFlight.Valid(SomeFlight);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


    }
}
