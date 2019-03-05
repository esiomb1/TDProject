using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstPhoneCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //test to see that it exists 
            Assert.IsNotNull(APhoneCustomer);
        }


        [TestMethod]
        public void PhoneCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //create some test data to assign to the property 
            string SomePhoneCustomer = "Jake";
            //assign the data to the property
            APhoneCustomer.PhoneCustomer = SomePhoneCustomer;
            //test to see that it exists 
            Assert.AreEqual(APhoneCustomer.PhoneCustomer, SomePhoneCustomer);
        }

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
            //create some test data to test the method 
            string SomeAPhoneCustomer = "Jake";
            //invoke the method 
            Error = APhoneCustomer.Valid(SomeAPhoneCustomer);
            //test to see that the result is OK i.e there was no error message returned 
            Assert.AreEqual(Error, "");
        }





    }
}
