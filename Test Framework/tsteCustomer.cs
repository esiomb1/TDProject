using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tsteCustomer
    {

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clseCustomer ACustomer = new clseCustomer();
            // test to see that it exists 
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class
            clseCustomer ACustomer = new clseCustomer();
            //Create some test data to assign to the property 
            Boolean TestData = true;
            //assight the data to the property 
            ACustomer.Active = TestData;
            // test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void DatePropertyOK()
        {
            //create an instance of the class
            clseCustomer ACustomer = new clseCustomer();
            //Create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assight the data to the property 
            ACustomer.Date = TestData;
            // test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Date, TestData);
        }

        // FIRST NAME TEST 

        [TestMethod]
        //used to test the County property of the class
        public void FirstNamePropertyOk()
        {
            //create an instance of the class
            clseCustomer AFirstName = new clseCustomer();
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
            clseCustomer AFirstName = new clseCustomer();
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
            clseCustomer AFirstName = new clseCustomer();
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
            clseCustomer AFirstName = new clseCustomer();
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
            clseCustomer AFirstName = new clseCustomer();
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
            clseCustomer AFirstName = new clseCustomer();
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

        // LAST NAME TEST 

        [TestMethod]
        //used to test the County property of the class
        public void LastNamePropertyOk()
        {
            //create an instance of the class
            clseCustomer ALastName = new clseCustomer();
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
            clseCustomer ALastName = new clseCustomer();
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
            clseCustomer ALastName = new clseCustomer();
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
            clseCustomer ALastName = new clseCustomer();
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
            clseCustomer ALastName = new clseCustomer();
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
            clseCustomer ALastName = new clseCustomer();
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
            clseCustomer AnAddress = new clseCustomer();
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
            clseCustomer AnAddress = new clseCustomer();
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
            clseCustomer AnAddress = new clseCustomer();
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
            clseCustomer AnAddress = new clseCustomer();
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
            clseCustomer AnAddress = new clseCustomer();
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
            clseCustomer AnAddress = new clseCustomer();
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
            clseCustomer APostCode = new clseCustomer();
            //create a variable to store the name of a county
            string SomePostCode;
            //assign a county to the variable
            SomePostCode = "Eileen";
            //try to send some data to the Customer property
            APostCode.Customer = SomePostCode;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(APostCode.Customer, SomePostCode);
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PostCodeMinLessOne()
        {
            //create an instance of the class
            clseCustomer APostCode = new clseCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePostCode = "";
            Error = APostCode.Valid(SomePostCode);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PostCodeMinBoundary()
        {
            //create an instance of the class
            clseCustomer APostCode = new clseCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePostCode = " b ";
            Error = APostCode.Valid(SomePostCode);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class
            clseCustomer APostCode = new clseCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePostCode = " bgjhvjmhvfjhcgvhcnbvjhvmnvhvhvuyjhvfhfhyvgvycyfjgvuhcucjhvmhvhvhvhgv ";
            Error = APostCode.Valid(SomePostCode);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PostCodeMid()
        {
            //create an instance of the class
            clseCustomer AnPostCode = new clseCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePostCode = " bgjhvjmhvfjhcggv ";
            Error = AnPostCode.Valid(SomePostCode);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        //test that theFirstName validation throws an error when Customer is blank
        public void PostCodeEtremeMax()
        {
            //create an instance of the class
            clseCustomer APostCode = new clseCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            //create test data t test method
            string SomePostCode = "";
            // create some test data to test the method 
            SomePostCode = SomePostCode.PadRight(500, 'a');
            // invoke the method
            Error = APostCode.Valid(SomePostCode);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }























































































        [TestMethod]
        //used to test the CustomerNo property of the class
        public void CustomerNoPropertyOk()
        {
            //create an instance of the class
            clseCustomer ACustomer = new clseCustomer();
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
            clseCustomer ACustomer = new clseCustomer();
            //test to see if the valid method exists
            ACustomer.Valid("James");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void CustomerMinLessOne()
        {
            //create an instance of the class
            clseCustomer ACustomer = new clseCustomer();
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
            clseCustomer ACustomer = new clseCustomer();
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
            clseCustomer ACustomer = new clseCustomer();
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
            clseCustomer ACustomer = new clseCustomer();
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
            clseCustomer ACustomer = new clseCustomer();
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
