using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstAdministrator
    {

        int AdministratorID = 10;
        int CustomerID = 1;
        int PhoneID = 3;
        //private data member for the Admini ID property
        
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //test to see that it exists 
            Assert.IsNotNull(AnAdministrator);
        }



        [TestMethod]
        public void ActivePropertyOK()

        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            AnAdministrator.Active = TestData;
            //test to see that it exists 
            Assert.AreEqual(AnAdministrator.Active, TestData);
        }

        /*[TestMethod]
        public void AdministratorIDMinLessOne()
        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int AdministratorID = ""; //this should trigger an error
            //invoke the method
            Error = AnAdministrator.Valid(AdministratorID, CustomerID, PhoneID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }*/


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnAdministrator.Valid(AdministratorID,CustomerID,PhoneID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void CustomerIDPropertyOK()

        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //create some test data to assign to the property 
            int TestData = 1;
            //assign the data to the property
            AnAdministrator.CustomerID = TestData;
            //test to see that it exists 
            Assert.AreEqual(AnAdministrator.CustomerID, TestData);
        }

        [TestMethod]
        public void PhoneIDPropertyOK()

        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //create some test data to assign to the property 
            int TestData = 3;
            //assign the data to the property
            AnAdministrator.PhoneID = TestData;
            //test to see that it exists 
            Assert.AreEqual(AnAdministrator.PhoneID, TestData);
        }

        [TestMethod]
        public void AdministratorIDPropertyOK()

        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //create some test data to assign to the property 
            int TestData = 10;
            //assign the data to the property
            AnAdministrator.AdministratorID = TestData;
            //test to see that it exists 
            Assert.AreEqual(AnAdministrator.AdministratorID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()

        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            int AdministratorID = 10;
            //invoke the method 
            Found = AnAdministrator.Find(AdministratorID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);


        }

        [TestMethod]
        public void TestAdministratorIDFound()

        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true; 
            //create some test data to use with the method 
            int AdministratorID = 10;
            //invoke the method 
            Found = AnAdministrator.Find(AdministratorID);
            //check the administrator id
            if (AnAdministrator.AdministratorID != 10)
            {
                OK = false; 
            }
            //test to see that the result is correct 
            Assert.IsTrue(Found);


        }



        [TestMethod]
        public void TestCustomerIDFound()

        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method 
            int AdministratorID = 10;
            //invoke the method 
            Found = AnAdministrator.Find(AdministratorID);
            //check the administrator id
            if (AnAdministrator.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(Found);


        }


        [TestMethod]
        public void TestPhoneIDFound()

        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method 
            int AdministratorID = 10;
            //invoke the method 
            Found = AnAdministrator.Find(AdministratorID);
            //check the administrator id
            if (AnAdministrator.PhoneID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(Found);


        }


    } 


}


