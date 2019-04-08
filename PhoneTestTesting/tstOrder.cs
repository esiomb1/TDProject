using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //test to see that it exists 
            Assert.IsNotNull(AOrder);
        }

        [TestMethod]
        public void OrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property 
            string SomeOrder = "John";
            //assign the data to the property
            AOrder.Order = SomeOrder;
            //test to see that it exists 
            Assert.AreEqual(AOrder.Order, SomeOrder);
        }

        [TestMethod]
        public void OrderNumPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property 
            Int32 OrderNo = 3454223;
            //assign the data to the property
            AOrder.OrderNo = OrderNo;
            //test to see that it exists 
            Assert.AreEqual(AOrder.OrderNo, OrderNo);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create a string variable to store the results of the validation 
            String Error = "";
            //create some test data to test the method 
            string SomeOrder = "Jake";
            //invoke the method 
            Error = AOrder.Valid(SomeOrder);
            //test to see that the result is OK i.e there was no error message returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void OrderMinLessOne()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeOrder = "";
            Error = AOrder.Valid(SomeOrder);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void OrderMinBoundary()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeOrder = " O ";
            Error = AOrder.Valid(SomeOrder);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void OrderMinPlusOne()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeOrder = " OO ";
            Error = AOrder.Valid(SomeOrder);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void OrderMaxLessOne()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeOrder = " ooooooooooooooooooooooooooooooooooooooooooooooooo ";
            Error = AOrder.Valid(SomeOrder);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void OrderMaxBoundary()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeOrder = " oooooooooooooooooooooooooooooooooooooooooooooooooo ";
            Error = AOrder.Valid(SomeOrder);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void OrderMaxPlusOne()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeOrder = " ooooooooooooooooooooooooooooooooooooooooooooooooooo ";
            Error = AOrder.Valid(SomeOrder);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //test that the Customer validation throws an error when Customer is blank
        public void OrderMid()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create a variable to record the result of the validation test
            String Error = "";
            // create some test data to test the method 
            string SomeOrder = " ooooooooooooooooooooooooo ";
            Error = AOrder.Valid(SomeOrder);
            // test to see the result is not ok ie there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            AOrder.Active = TestData;
            //test to see that it exists 
            Assert.AreEqual(AOrder.Active, TestData);
        }


        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AOrder.OrderDate = TestData;
            //test to see that it exists 
            Assert.AreEqual(AOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property 
            int TestData = 20;
            //assign the data to the property
            AOrder.OrderNo = TestData;
            //test to see that it exists 
            Assert.AreEqual(AOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void PhoneIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property 
            int TestData = 3;
            //assign the data to the property
            AOrder.PhoneID = TestData;
            //test to see that it exists 
            Assert.AreEqual(AOrder.PhoneID, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property 
            int TestData = 899;
            //assign the data to the property
            AOrder.Price = TestData;
            //test to see that it exists 
            Assert.AreEqual(AOrder.Price, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property 
            int TestData = 1;
            //assign the data to the property
            AOrder.CustomerID = TestData;
            //test to see that it exists 
            Assert.AreEqual(AOrder.CustomerID, TestData);
        }



        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            int OrderNo = 20;
            //invoke the method 
            Found = AOrder.Find(OrderNo);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int OrderNo = 20;
            //invoke the method 
            Found = AOrder.Find(OrderNo);
            //check the order no 
            if (AOrder.OrderNo != 20)
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
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int OrderNo = 20;
            //invoke the method 
            Found = AOrder.Find(OrderNo);
            //check the order no 
            if (AOrder.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int OrderNo = 20;
            //invoke the method 
            Found = AOrder.Find(OrderNo);
            //check the order no 
            if (AOrder.OrderDate !=Convert.ToDateTime("22/02/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int OrderNo = 20;
            //invoke the method 
            Found = AOrder.Find(OrderNo);
            //check the order no 
            if (AOrder.PhoneID != 3)
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
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int OrderNo = 20;
            //invoke the method 
            Found = AOrder.Find(OrderNo);
            //check the order no 
            if (AOrder.Price != 899)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }







    }

}
