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

        // FIRST NAME TEST 

        [TestMethod]
        //used to test the County property of the class
        public void FirstNamePropertyOk()
        {
            //create an instance of the class
            clseBookings AFirstName = new clseBookings();
            //create a variable to store the name of a county
            string SomeFirstName;
            //assign a county to the variable
            SomeFirstName = "Eileen";
            //try to send some data to the Customer property
            AFirstName.Customer = SomeFirstName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AFirstName.Customer, SomeFirstName);
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void FirstNameMinLessOne()
        {
            //create an instance of the class
            clseBookings AFirstName = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeFirstName = "";
            Error = AFirstName.Valid(SomeFirstName);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void FirstNameMinBoundary()
        {
            //create an instance of the class
            clseBookings AFirstName = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeFirstName = " b ";
            Error = AFirstName.Valid(SomeFirstName);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class
            clseBookings AFirstName = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeFirstName = " bgjhvjmhvfjhcgvhcnbvjhvmnvhvhvuyjhvfhfhyvgvycyfjgvuhcucjhvmhvhvhvhgv ";
            Error = AFirstName.Valid(SomeFirstName);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void FirstNameMid()
        {
            //create an instance of the class
            clseBookings AFirstName = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeFirstName = " bgjhvjmhvfjhcggv ";
            Error = AFirstName.Valid(SomeFirstName);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        //test that theFirstName validation throws an error when Customer is blank
        public void FirstNameEtremeMax()
        {
            //create an instance of the class
            clseBookings AFirstName = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            //create test data t test method
            string SomeFirstName = "";
            // create some test data to test the method 
            SomeFirstName = SomeFirstName.PadRight(500, 'a');
            // invoke the method
            Error = AFirstName.Valid(SomeFirstName);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }

        // firstname done 
        // LAST NAME TEST 

        [TestMethod]
        //used to test the County property of the class
        public void LastNamePropertyOk()
        {
            //create an instance of the class
            clseBookings ALastName = new clseBookings();
            //create a variable to store the name of a county
            string SomeLastName;
            //assign a county to the variable
            SomeLastName = "Eileen";
            //try to send some data to the Customer property
            ALastName.Customer = SomeLastName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(ALastName.Customer, SomeLastName);
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void LastNameMinLessOne()
        {
            //create an instance of the class
            clseBookings ALastName = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeLastName = "";
            Error = ALastName.Valid(SomeLastName);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void LastNameMinBoundary()
        {
            //create an instance of the class
            clseBookings ALastName = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeLastName = " b ";
            Error = ALastName.Valid(SomeLastName);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class
            clseBookings ALastName = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeLastName = " bgjhvjmhvfjhcgvhcnbvjhvmnvhvhvuyjhvfhfhyvgvycyfjgvuhcucjhvmhvhvhvhgv ";
            Error = ALastName.Valid(SomeLastName);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void LastNameMid()
        {
            //create an instance of the class
            clseBookings ALastName = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeLastName = " bgjhvjmhvfjhcggv ";
            Error = ALastName.Valid(SomeLastName);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        //test that theFirstName validation throws an error when Customer is blank
        public void LastNameEtremeMax()
        {
            //create an instance of the class
            clseBookings ALastName = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            //create test data t test method
            string SomeLastName = "";
            // create some test data to test the method 
            SomeLastName = SomeLastName.PadRight(500, 'a');
            // invoke the method
            Error = ALastName.Valid(SomeLastName);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }



        // ADDRESS PROPERT TEST 



        [TestMethod]
        //used to test the County property of the class
        public void AddressPropertyOk()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to store the name of a county
            string SomeAddress;
            //assign a county to the variable
            SomeAddress = "Eileen";
            //try to send some data to the Customer property
            AnAddress.Customer = SomeAddress;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AnAddress.Customer, SomeAddress);
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void AddressMinLessOne()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeAddress = "";
            Error = AnAddress.Valid(SomeAddress);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void AddressMinBoundary()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeAddress = " b ";
            Error = AnAddress.Valid(SomeAddress);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void AddressMaxPlusOne()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeAddress = " bgjhvjmhvfjhcgvhcnbvjhvmnvhvhvuyjhvfhfhyvgvycyfjgvuhcucjhvmhvhvhvhgv ";
            Error = AnAddress.Valid(SomeAddress);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void AddressMid()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeAddress = " bgjhvjmhvfjhcggv ";
            Error = AnAddress.Valid(SomeAddress);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        //test that theFirstName validation throws an error when Customer is blank
        public void AddressEtremeMax()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            //create test data t test method
            string SomeAddress = "";
            // create some test data to test the method 
            SomeAddress = SomeAddress.PadRight(500, 'a');
            // invoke the method
            Error = AnAddress.Valid(SomeAddress);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        //POST CODE  PROPERTY TEST 



        [TestMethod]
        //used to test the County property of the class
        public void PostCodePropertyOk()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to store the name of a county
            string SomePostCode;
            //assign a county to the variable
            SomePostCode = "Eileen";
            //try to send some data to the Customer property
            AnAddress.Customer = SomePostCode;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AnAddress.Customer, SomePostCode);
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PostCodeMinLessOne()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePostCode = "";
            Error = AnAddress.Valid(SomePostCode);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PostCodeMinBoundary()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePostCode = " b ";
            Error = AnAddress.Valid(SomePostCode);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePostCode = " bgjhvjmhvfjhcgvhcnbvjhvmnvhvhvuyjhvfhfhyvgvycyfjgvuhcucjhvmhvhvhvhgv ";
            Error = AnAddress.Valid(SomePostCode);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PostCodeMid()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePostCode = " bgjhvjmhvfjhcggv ";
            Error = AnAddress.Valid(SomePostCode);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        //test that theFirstName validation throws an error when Customer is blank
        public void PostCodeEtremeMax()
        {
            //create an instance of the class
            clseBookings AnAddress = new clseBookings();
            //create a variable to record the result of the validation test
            String Error = "";
            //create test data t test method
            string SomePostCode = "";
            // create some test data to test the method 
            SomePostCode = SomePostCode.PadRight(500, 'a');
            // invoke the method
            Error = AnAddress.Valid(SomePostCode);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        // CARD NO Okay
        [TestMethod]
        //used to test the CustomerNo property of the class
        public void CardNoPropertyOk()
        {
            //create an instance of the class
            clseBookings ACard = new clseBookings();
            //create a variable to store the Id of a County
            Int32 CardNo;
            //assign a value to the variable
            CardNo = 1273667523;
            //try to send some data to the CustomerNo property
            ACard.CardNo = CardNo;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(ACard.CardNo, CardNo);
        }



    }
}
