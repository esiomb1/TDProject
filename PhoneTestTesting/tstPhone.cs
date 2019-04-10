using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstPhone
    {      
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //test to see that it exists 
            Assert.IsNotNull(APhone);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone AnPhone = new clsPhone();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnPhone.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPhone.Active, TestData);
        }

        [TestMethod]
        public void PhoneIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone AnPhone = new clsPhone();
            //create some test data to assign to the property
            int TestData = 3;
            //assign the data to the property
            AnPhone.PhoneID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPhone.PhoneID, TestData);

        }

        [TestMethod]
        public void ColourPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone AnPhone = new clsPhone();
            //create some test data to assign to the property
            string TestData = "Red";
            //assign the data to the property
            AnPhone.Colour = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPhone.Colour, TestData);

        }


        [TestMethod]
        public void PhoneMakePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone AnPhone = new clsPhone();
            //create some test data to assign to the property
            string TestData = "Apple";
            //assign the data to the property
            AnPhone.PhoneMake = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPhone.PhoneMake, TestData);

        }

        [TestMethod]
        public void PhoneModelPropertyOK()
        {
            //create an instance of the class we want to create
            clsPhone AnPhone = new clsPhone();
            //create some test data to assign to the property
            string TestData = "iPhone 8 Plus";
            //assign the data to the property
            AnPhone.PhoneModel = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPhone.PhoneModel, TestData);

        }


        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsPhone AnPhone = new clsPhone();
            //create some test data to assign to the property
            decimal TestData = 899;
            //assign the data to the property
            AnPhone.Price = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPhone.Price, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsPhone AnPhone = new clsPhone();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            int PhoneID = 3;
            //invoke the method 
            Found = AnPhone.Find(PhoneID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPhoneIDFound()
        {
            //create an instance of the class we want to create
            clsPhone AnPhone = new clsPhone();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int PhoneID = 3;
            //invoke the method 
            Found = AnPhone.Find(PhoneID);
            //check the Phone ID 
            if (AnPhone.PhoneID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestColourFound()
        {
            //create an instance of the class we want to create
            clsPhone AnPhone = new clsPhone();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int PhoneID = 3;
            //invoke the method 
            Found = AnPhone.Find(PhoneID);
            //check the Colour
            if (AnPhone.Colour != "Red")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPhoneMakeFound()
        {
            //create an instance of the class we want to create
            clsPhone AnPhone = new clsPhone();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int PhoneID = 3;
            //invoke the method 
            Found = AnPhone.Find(PhoneID);
            //check the PhoneMake
            if (AnPhone.PhoneMake != "Apple")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestPhoneModelFound()
        {
            //create an instance of the class we want to create
            clsPhone AnPhone = new clsPhone();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int PhoneID = 3;
            //invoke the method 
            Found = AnPhone.Find(PhoneID);
            //check the PhoneModel
            if (AnPhone.PhoneModel != "iPhone 8 Plus")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsPhone AnPhone = new clsPhone();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int PhoneID = 3;
            //invoke the method 
            Found = AnPhone.Find(PhoneID);
            //check the Price
            if (AnPhone.Price != Convert.ToDecimal(899))
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
            clsPhone AnPhone = new clsPhone();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int PhoneID = 3;
            //invoke the method 
            Found = AnPhone.Find(PhoneID);
            //check the Phone ID 
            if (AnPhone.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}
