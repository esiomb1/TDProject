using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomernkkCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomernkkCollection AllShowings = new clsCustomernkkCollection();
            //test to see that it exists
            Assert.IsNotNull(AllShowings);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create the instance of the class we want to create 
            clsCustomernkkCollection AllShowings = new clsCustomernkkCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllShowings.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllShowings.Count, SomeCount);
        }

        [TestMethod]
        public void AllCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomernkkCollection Customer = new clsCustomernkkCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomernkk> TestList = new List<clsCustomernkk>();
            //add an item to the list
            //create the item of the test data
            clsCustomernkk TestItem = new clsCustomernkk();
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.Name = "James";
            TestItem.Mobile = "07896857634";
            TestItem.Email = "john@gmail.com";
            TestItem.DateOfBirth = "04/01/1990";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Customer.AllCustomer = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.AllCustomer, TestList);
        }
    }
}
    
