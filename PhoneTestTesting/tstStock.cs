using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists 
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AStock.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStock.Active, TestData);
        }


        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 50;
            //assign the data to the property
            AStock.OrderNo = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStock.OrderNo, TestData);

        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AStock.Quantity = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStock.Quantity, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            int OrderNo = 50;
            //invoke the method 
            Found = AStock.Find(OrderNo);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int OrderNo = 50;
            //invoke the method 
            Found = AStock.Find(OrderNo);
            //check the Phone ID 
            if (AStock.OrderNo != 50)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int OrderNo = 50;
            //invoke the method 
            Found = AStock.Find(OrderNo);
            //check the Phone ID 
            if (AStock.Quantity != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

    }
}
