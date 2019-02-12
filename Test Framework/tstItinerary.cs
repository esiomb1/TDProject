using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{

    [TestClass]
    public class tstItinerary
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsItinerary AnItinerary = new clsItinerary();
            // test to see that it exists 
            Assert.IsNotNull(AnItinerary);
        }


        [TestMethod]
        //used to test the Itinerary property of the class
        public void ItineraryPropertyOk()
        {
            //create an instance of the class
            clsItinerary AnItinerary = new clsItinerary();
            //create a variable to store the name of a county
            string SomeItinerary;
            //assign a county to the variable
            SomeItinerary = "Eileen";
            //try to send some data to the Customer property
            AnItinerary.Itinerary = SomeItinerary;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AnItinerary.Itinerary, SomeItinerary);
        }


        [TestMethod]
        //used to test the CustomerNo property of the class
        public void ItineryNoPropertyOk()
        {
            //create an instance of the class
            clsItinerary AnItinerary = new clsItinerary();
            //create a variable to store the Id of a County
            Int32 ItineraryNo;
            //assign a value to the variable
            ItineraryNo = 1273;
            //try to send some data to the CustomerNo property
            AnItinerary.ItineraryNo = ItineraryNo;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AnItinerary.ItineraryNo, ItineraryNo);
        }



        [TestMethod]
        //used to test the presence of the Valid Method
        public void Valid()
        {
            //create an instance of the class
            clsItinerary AnItinerary = new clsItinerary();
            //test to see if the valid method exists
            AnItinerary.Valid("holiday");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void ItineraryMinLessOne()
        {
            //create an instance of the class
            clsItinerary AnItinerary = new clsItinerary();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeItinerary = "";
            Error = AnItinerary.Valid(SomeItinerary);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void ItineryMinBoundary()
        {
            //create an instance of the class
            clsItinerary AnItinerary = new clsItinerary();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeItinerary = " b ";
            Error = AnItinerary.Valid(SomeItinerary);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void ItineraryMaxPlusOne()
        {
            //create an instance of the class
            clsItinerary AnItinerary = new clsItinerary();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeItinerary = " bgjhvjmhvfjhcgvhcnbvjhvmnvhvhvuyjhvfhfhyvgvycyfjgvuhcucjhvmhvhvhvhgv ";
            Error = AnItinerary.Valid(SomeItinerary);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }




        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void ItineraryMid()
        {
            //create an instance of the class
            clsItinerary AnItinerary = new clsItinerary();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeItinerary = " bgjhvjmhvfjhcggv ";
            Error = AnItinerary.Valid(SomeItinerary);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void ItineraryEtremeMax()
        {
            //create an instance of the class
            clsItinerary AnItinerary = new clsItinerary();
            //create a variable to record the result of the validation test
            String Error = "";
            //create test data t test method
            string SomeItinerary = "";
            // create some test data to test the method 
            SomeItinerary = SomeItinerary.PadRight(500, 'a');
            // invoke the method
            Error = AnItinerary.Valid(SomeItinerary);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }







    }




}
