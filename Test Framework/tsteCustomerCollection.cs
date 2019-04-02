using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Test_Framework
{
    [TestClass]
    public class tsteCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clseCustomerCollection AllCustomers = new clseCustomerCollection();
            //test to see if the class exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clseCustomerCollection AllCustomers = new clseCustomerCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 0;
            //asig the data to the property
            AllCustomers.Count = SomeCount;
            // test to see if the values are the same 
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void AllCustomersOk()
        {
            //create an instance of the class we want to create
            clseCustomerCollection Customers = new clseCustomerCollection();
            //create some test data to assign to the property
            //in this case the data will be a list of objects
            List<clseCustomer> TestList = new List<clseCustomer>();
            //add an item to the list
            //create the item of test data
            clseCustomer TestItem = new clseCustomer();
            //set its properties
            TestItem.CustomerNo = 4375;
            TestItem.FirstName = "John";
            TestItem.LastName = "Make";
            TestItem.Address = " 11 donald Road";
            TestItem.PostCode = " KT6 8RJ";
            TestItem.EmailAddress = " JM@gmail.com";
            TestItem.Mobile = "07838774833";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Customers.AllCustomers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Customers.AllCustomers, TestList);
        }




        //[TestMethod]
        //public void TwoCustomersPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection Customers = new clsCustomerCollection();
        //    // test to see tht the two values are the same 
        //    Assert.AreEqual(Customers.Count, 2);

        //
    }





















    }

