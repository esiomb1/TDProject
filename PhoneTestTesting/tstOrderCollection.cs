using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instnace of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllOrders);

        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instnace of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property 
            Int32 SomeCount = 2;
            //assign the data to the property 
            AllOrders.Count = SomeCount;
            //test to see that it exists 
            Assert.AreEqual(AllOrders.Count, SomeCount);

        }

       /* [TestMethod]
        public void AllOrdersOK()
        {
            //create an instnace of the class we want to create
            clsOrderCollection Orders = new clsOrderCollection();
            //create some test data to assign to the property 
            List<clsOrder> TestList = new List<clsOrder>();
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.OrderNo = 122332;
            TestItem.CustomerName = "Jake";
            TestItem.OrderDate = 12 / 05 / 2019;
            TestItem.PhoneMake = "IPhone 8 Plus";
            TestItem.Minutes = "Unlimited";
            TestItem.Text = "Unlimited";
            TestItem.Price = 700;
            //Add the item to te test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            Orders.AllOrders = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(Orders.AllOrders, TestList);

        }*/

        /*[TestMethod]
        public void CountMatchesList()
        {
            //create an instnace of the class we want to create
            clsOrderCollection Orders = new clsOrderCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list 
            //create the item of test data 
            clsOrder TestItem = new clsOrder(); ;
            //set its properties 
            TestItem.OrderNo = 122332;
            TestItem.CustomerName = "Jake";
            TestItem.OrderDate = 12 / 05 / 2019;
            TestItem.PhoneMake = "IPhone 8 Plus";
            TestItem.Minutes = "Unlimited";
            TestItem.Text = "Unlimited";
            TestItem.Price = 700;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            Orders.AllOrders = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Orders.Count, TestList.Count);

        }*/

        [TestMethod]
        public void TwoOrdersPresent()
        {
            //create an instance of the class
            clsOrderCollection Orders = new clsOrderCollection();
            //test to see that the two values are the same 
            Assert.AreEqual(Orders.Count, 2);
        }


    }
}
