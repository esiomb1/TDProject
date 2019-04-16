using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstPhoneCustomer
    {
       


        //good test data 
        //create some test data to pass to the method 
        int CustomerID = 1;
        string FirstName = "Jack";
        string Surname = "Pierce";
        string Postcode = "le1 3pw";
        string Address = "46 Oxford street";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //test to see that it exists 
            Assert.IsNotNull(APhoneCustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            APhoneCustomer.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhoneCustomer.Active, TestData);
        }

        /*[TestMethod]
        public void PhoneCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create some test data to assign to the property 
            string SomePhoneCustomer = "Jake";
            //assign the data to the property
            APhoneCustomer.CustomerID = SomePhoneCustomer;
            //test to see that it exists 
            Assert.AreEqual(APhoneCustomer.CustomerID, SomePhoneCustomer);
        }*/

        [TestMethod]
        public void PhoneCustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create some test data to assign to the property 
            Int32 PhoneCustomerNo = 1;
            //assign the data to the property
            APhoneCustomer.PhoneCustomerNo = PhoneCustomerNo;
            //test to see that it exists 
            Assert.AreEqual(APhoneCustomer.PhoneCustomerNo, PhoneCustomerNo);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create a string variable to store the results of the validation 
            String Error = "";            
            //invoke the method                               
            Error = APhoneCustomer.Valid(CustomerID,FirstName,Surname,Address,Postcode);
            //test to see that the result is OK i.e there was no error message returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PhoneCustomerMinLessOne()
        {
            //create an instance of the class
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomePhoneCustomer = "";
            Error = APhoneCustomer.Valid(SomePhoneCustomer);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PhoneCustomerMinBoundary()
        {
            //create an instance of the class
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create a string variable to store the result of the validation 
            String Error = "";
            string SomePhoneCustomer = " s ";
            Error = APhoneCustomer.Valid(SomePhoneCustomer);
            // test to see that the result is OK i.e there was no error message returned 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PhoneCustomerMinPlusOne()
        {
            //create an instance of the class
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create a string variable to store the result of the validation 
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method           
            String Error = "";
            string SomePhoneCustomer = " ss ";
            Error = APhoneCustomer.Valid(SomePhoneCustomer);
            // test to see that the result is OK i.e there was no error message returned 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PhoneCustomerMaxLessOne()
        {
            //create an instance of the class
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create a string variable to store the result of the validation 
            String Error = "";
            string SomePhoneCustomer = "sssssssssssssssssssssssssssssssssssssssssssssssss";
            Error = APhoneCustomer.Valid(SomePhoneCustomer);
            // test to see that the result is OK i.e there was no error message returned 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PhoneCustomerMaxBoundary()
        {
            //create an instance of the class
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create a string variable to store the result of the validation 
            String Error = "";
            string SomePhoneCustomer = "ssssssssssssssssssssssssssssssssssssssssssssssssss";
            Error = APhoneCustomer.Valid(SomePhoneCustomer);
            // test to see that the result is OK i.e there was no error message returned 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PhoneCustomerMaxPlusOne()
        {
            //create an instance of the class
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create a string variable to store the result of the validation 
            String Error = "";
            string SomePhoneCustomer = "sssssssssssssssssssssssssssssssssssssssssssssssssss";
            Error = APhoneCustomer.Valid(SomePhoneCustomer);
            // test to see that the result is OK i.e there was no error message returned 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void PhoneCustomerMid()
        {
            //create an instance of the class
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create a string variable to store the result of the validation 
            String Error = "";
            string SomePhoneCustomer = "Sssssssssssssssssssssssss";
            Error = APhoneCustomer.Valid(SomePhoneCustomer);
            // test to see that the result is OK i.e there was no error message returned 
            Assert.AreEqual(Error, "");

        }


        //test that the Customer validation throws an error when Customer is blank
        /*[TestMethod]
        public void PhoneCustomerExtremeMax()
         {
             //create an instance of the class
             clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
             //create a string variable to store the result of the validation 
             String Error = "";
             //create some test data to test the method 
             string SomePhoneCustomer = "";
             //pad the string with characters 
             SomePhoneCustomer = SomePhoneCustomer.PadRight(500, 's');
             //invoke the method 
             Error = APhoneCustomer.Valid(SomePhoneCustomer);
             // test to see that the result is OK i.e there was no error message returned 
             Assert.AreEqual(Error, "");

         }*/

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create some test data to assign to the property 
            int TestData = 1;
            //assign the data to the property
            APhoneCustomer.CustomerID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhoneCustomer.CustomerID, TestData);
        }


        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create some test data to assign to the property 
            string TestData = "46 Oxford Street";
            //assign the data to the property
            APhoneCustomer.Address = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhoneCustomer.Address, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create some test data to assign to the property 
            string TestData = "Jack";
            //assign the data to the property
            APhoneCustomer.FirstName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhoneCustomer.FirstName, TestData);
        }


        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create some test data to assign to the property 
            string TestData = "Pierce";
            //assign the data to the property
            APhoneCustomer.Surname = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhoneCustomer.Surname, TestData);
        }


        [TestMethod]
        public void PostcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create some test data to assign to the property 
            string TestData = "le1 3pw";
            //assign the data to the property
            APhoneCustomer.Postcode = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhoneCustomer.Postcode, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            int CustomerID = 1;
            //invoke the method 
            Found = APhoneCustomer.Find(CustomerID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }


     


        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int CustomerID = 1;
            //invoke the method 
            Found = APhoneCustomer.Find(CustomerID);
            //check the Phone ID 
            if (APhoneCustomer.Address != "46 Oxford Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int CustomerID = 1;
            //invoke the method 
            Found = APhoneCustomer.Find(CustomerID);
            //check the Phone ID 
            if (APhoneCustomer.FirstName != "Jack")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int  CustomerID = 1;
            //invoke the method 
            Found = APhoneCustomer.Find(CustomerID);
            //check the Phone ID 
            if (APhoneCustomer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int CustomerID = 1;
            //invoke the method 
            Found = APhoneCustomer.Find(CustomerID);
            //check the Phone ID 
            if (APhoneCustomer.Surname != "Pierce")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int CustomerID = 1;
            //invoke the method 
            Found = APhoneCustomer.Find(CustomerID);
            //check the Phone ID 
            if (APhoneCustomer.Postcode != "le1 3pw")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int CustomerID = 1;
            //invoke the method 
            Found = APhoneCustomer.Find(CustomerID);
            //check the Phone ID 
            if (APhoneCustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


    }

}


