using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstAdministrator
    {
        [TestMethod]
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




        [TestMethod]
        public void DateAddedPropertyOK()

        {
            //create an instance of the class we want to create 
            clsAdministrator AnAdministrator = new clsAdministrator();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAdministrator.DateAdded = TestData;
            //test to see that it exists 
            Assert.AreEqual(AnAdministrator.DateAdded, TestData);
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


