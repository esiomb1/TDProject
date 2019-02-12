using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test_Framework
{
    [TestClass]
    public class tstPassenger
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsPassenger APassenger = new clsPassenger();
            // test to see that it exists 
            Assert.IsNotNull(APassenger);
        }


        [TestMethod]
        //used to test the Passenger property of the class
        public void PassengerPropertyOk()
        {
            //create an instance of the class
            clsPassenger APassenger = new clsPassenger();
            //create a variable to store the name of a county
            string SomePassenger;
            //assign a county to the variable
            SomePassenger = "Eileen";
            //try to send some data to the Customer property
            APassenger.Passenger = SomePassenger;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(APassenger.Passenger, SomePassenger);
        }


        [TestMethod]
        //used to test the CustomerNo property of the class
        public void PassengerNoPropertyOk()
        {
            //create an instance of the class
            clsPassenger APassenger = new clsPassenger();
            //create a variable to store the Id of a County
            Int32 PassengerNo;
            //assign a value to the variable
            PassengerNo = 123;
            //try to send some data to the CustomerNo property
            APassenger.PassengerNo = PassengerNo;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(APassenger.PassengerNo, PassengerNo);
        }



        [TestMethod]
        //used to test the presence of the Valid Method
        public void Valid()
        {
            //create an instance of the class
            clsPassenger APassenger = new clsPassenger();
            //test to see if the valid method exists
            APassenger.Valid("James");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PassengerMinLessOne()
        {
            //create an instance of the class
            clsPassenger APassenger = new clsPassenger();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePassenger = "";
            Error = APassenger.Valid(SomePassenger);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PassengerMinBoundary()
        {
            //create an instance of the class
            clsPassenger APassenger = new clsPassenger();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePassenger = " b ";
            Error = APassenger.Valid(SomePassenger);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PassengerMaxPlusOne()
        {
            //create an instance of the class
            clsPassenger APassenger = new clsPassenger();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePassenger = " bgjhvjmhvfjhcgvhcnbvjhvmnvhvhvuyjhvfhfhyvgvycyfjgvuhcucjhvmhvhvhvhgv ";
            Error = APassenger.Valid(SomePassenger);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }




        [TestMethod]
        //test that the Passenger validation throws an error when Customer is blank
        public void PassengerMid()
        {
            //create an instance of the class
            clsPassenger APassenger = new clsPassenger();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePassenger = " bgjhvjmhvfjhcggv ";
            Error = APassenger.Valid(SomePassenger);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        //test that the Passenger validation throws an error when Customer is blank
        public void PassengerEtremeMax()
        {
            //create an instance of the class
            clsPassenger APassenger = new clsPassenger();
            //create a variable to record the result of the validation test
            String Error = "";
            //create test data t test method
            string SomePassenger = "";
            // create some test data to test the method 
            SomePassenger = SomePassenger.PadRight(500, 'a');
            // invoke the method
            Error = APassenger.Valid(SomePassenger);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }
    }
}
