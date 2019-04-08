using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tsteBookings
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clseBookings ABooking = new clseBookings();
            // test to see that it exists 
            Assert.IsNotNull(ABooking);
        }



        [TestMethod]
        //used to test the County property of the class
        public void BookingPropertyOk()
        {
            //create an instance of the class
            clseBookings ABooking = new clseBookings();
            //create a variable to store the name of a Booking
            string SomeBooking;
            //assign a county to the variable
            SomeBooking = "turkey";
            //try to send some data to the Customer property
            ABooking.Booking = SomeBooking;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(ABooking.Booking, SomeBooking);
        }


        [TestMethod]
        //used to test the Booking no property of the class
        public void BookingNoPropertyOk()
        {
            //create an instance of the class
            clseBookings ABooking = new clseBookings();
            //create a variable to store the Id of a County
            Int32 BookingNo;
            //assign a value to the variable
            BookingNo = 567;
            //try to send some data to the CustomerNo property
            ABooking.BookingNo = BookingNo;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(ABooking.BookingNo, BookingNo);
        }



        [TestMethod]
        //used to test the presence of the Valid Method
        public void Valid()
        {
            //create an instance of the class
            clseBookings ABooking = new clseBookings();
            //test to see if the valid method exists
            ABooking.Valid("James");
        }


        [TestMethod]
        //test that the Customer validation throws an error when Bookings is blank
        public void BookingMinLessOne()
        {
            //create an instance of the class
            clseBookings ABooking = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeBooking = "";
            Error = ABooking.Valid(SomeBooking);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Booking is blank
        public void BookingMinBoundary()
        {
            //create an instance of the class
            clseBookings ABooking = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeBooking = " b ";
            Error = ABooking.Valid(SomeBooking);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Bookingsis blank
        public void BookingMaxPlusOne()
        {
            //create an instance of the class
            clseBookings ABooking = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeBooking = " bgjhfssdsdsdvhvuyjhvfhfhyvgvycyfjgvuhcucjhvmhvhvhvhgv ";
            Error = ABooking.Valid(SomeBooking);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }




        [TestMethod]
        //test that the Customer validation throws an error when Bookings is blank
        public void BookingMid()
        {
            //create an instance of the class
            clseBookings ABooking = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeBooking = " bgjhvjmhvfjhcggv ";
            Error = ABooking.Valid(SomeBooking);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        //test that the Customer validation throws an error when Bookingss is blank
        public void BookingEtremeMax()
        {
            //create an instance of the class
            clseBookings ABooking = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            //create test data t test method
            string SomeBooking = "";
            // create some test data to test the method 
            SomeBooking = SomeBooking.PadRight(500, 'a');
            // invoke the method
            Error = ABooking.Valid(SomeBooking);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }







    }
}
