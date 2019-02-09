using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            // test to see that it exists 
            Assert.IsNotNull(ACustomer);
        }


        [TestMethod]
        //used to test the County property of the class
        public void CustomerPropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to store the name of a county
            string SomeCustomer;
            //assign a county to the variable
            SomeCustomer = "Eileen";
            //try to send some data to the Customer property
            ACustomer.Customer = SomeCustomer;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.Customer, SomeCustomer);
        }


        [TestMethod]
        //used to test the CustomerNo property of the class
        public void CustomerNoPropertyOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to store the Id of a County
            Int32 CustomerNo;
            //assign a value to the variable
            CustomerNo = 123;
            //try to send some data to the CustomerNo property
            ACustomer.CustomerNo = CustomerNo;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.CustomerNo, CustomerNo);
        }



        [TestMethod]
        //used to test the presence of the Valid Method
        public void Valid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test to see if the valid method exists
            ACustomer.Valid("James");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void CustomerMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeCustomer = "";
            Error = ACustomer.Valid(SomeCustomer);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void CustomerMinBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeCustomer = " b ";
            Error = ACustomer.Valid(SomeCustomer);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void CustomerMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeCustomer = " bgjhvjmhvfjhcgvhcnbvjhvmnvhvhvuyjhvfhfhyvgvycyfjgvuhcucjhvmhvhvhvhgv ";
            Error = ACustomer.Valid(SomeCustomer);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }




        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void CustomerMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeCustomer = " bgjhvjmhvfjhcggv ";
            Error = ACustomer.Valid(SomeCustomer);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void CustomerEtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            //create test data t test method
            string SomeCustomer = "";
            // create some test data to test the method 
            SomeCustomer = SomeCustomer.PadRight(500, 'a');
            // invoke the method
            Error = ACustomer.Valid(SomeCustomer);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }







    }
}
