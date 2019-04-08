using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic; 

namespace Test_Framework
{
    [TestClass]
    public class tstPhoneCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsPhoneCustomerCollection AllPhoneCustomers = new clsPhoneCustomerCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllPhoneCustomers);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clsPhoneCustomerCollection AllPhoneCustomers = new clsPhoneCustomerCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 0;
            //asig the data to the property
            AllPhoneCustomers.Count = SomeCount;
            // test to see if the values are the same 
            Assert.AreEqual(AllPhoneCustomers.Count, SomeCount);
        }

        /*[TestMethod]
        public void TwoPhoneCustomersPresent()
        {
            //create an instance of the class
            clsPhoneCustomer PhoneCustomers = new clsPhoneCustomer();
            //test to see that the two values are the same 
            Assert.AreEqual(PhoneCustomers.Count, 2);
        }*/



        [TestMethod]
        public void AllPhoneCustomersOK()
        {
            //create an instance of the class we want to create 
            clsPhoneCustomerCollection PhoneCustomers = new clsPhoneCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsPhoneCustomer> TestList = new List<clsPhoneCustomer>();
            //add an item to the list 
            //create the item of test data 
            clsPhoneCustomer TestItem = new clsPhoneCustomer();
            //set its properties 
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Jonny";
            TestItem.Surname = "Brown";
            TestItem.Address = "87 Oxford Street";
            TestItem.Postcode = "LE2 3LL";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            PhoneCustomers.AllPhoneCustomers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(PhoneCustomers.AllPhoneCustomers, TestList);

        }


        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create 
            clsPhoneCustomerCollection PhoneCustomers = new clsPhoneCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsPhoneCustomer> TestList = new List<clsPhoneCustomer>();
            //add an item to the list 
            //create the item of test data 
            clsPhoneCustomer TestItem = new clsPhoneCustomer();
            //set its properties 
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Jonny";
            TestItem.Surname = "Brown";
            TestItem.Address = "87 Oxford Street";
            TestItem.Postcode = "LE2 3LL";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            PhoneCustomers.AllPhoneCustomers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(PhoneCustomers.Count, TestList.Count);

        }




    }
}
