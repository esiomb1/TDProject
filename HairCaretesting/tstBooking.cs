using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstBooking
    {

        public object ABooking { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {

            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            //test to see that it exists
            Assert.IsNotNull(ABooking);
        }

        // new test
        //[TestMethod]
        //public void CustomerNoPropertyOK()
        //{
        //create an instance of the class we want to create
        //clsBooking ABooking = new clsBooking();
        //int CustomerNo = 0;
        //create some test data to assign to the property
        //Int32 CustomerNo = 1;
        //assign the data to the property
        // ABooking.CustomerNo = CustomerNo;
        //test to see that the two values are the same
        //    Assert.AreEqual(ABooking.CustomerNo, CustomerNo);


        [TestMethod]
        public void CustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            //int CustomerNo = 0;
            //create some test data to assign to the property
            clsCustomer SomeCustomer = new clsCustomer();
            //assign the data to the property
            ABooking.Customer = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(ABooking.Customer, SomeCustomer);
        }
        [TestMethod]
        public void BookingNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            //create test data
            ABooking.BookingNo = ABooking;
            //test to see the values are the same
            Assert.AreEqual(ABooking.BookingNo, ABooking);
        }
        [TestMethod]
        public void AdminPropertyOK()
        {
            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            string Admin = "Admin";
            //create the test data
            ABooking.Admin = Admin;
            //test to see the values are the same
            Assert.AreEqual(ABooking.Admin, Admin);
        }

        [TestMethod]
        public void BookingDatePropertyOK()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create data to test property
            DateTime BookingDate = DateTime.Now.Date;
            //assign data to property
            ABooking.BookingDate = BookingDate;
            //test to see that the two values are the same
            Assert.AreEqual(ABooking.BookingDate,BookingDate);
        }

      

        internal class varchar
        {
            public static implicit operator varchar(string v)
            {
                throw new NotImplementedException();
            }

            public static implicit operator string(varchar v)
            {
                throw new NotImplementedException();
            }
        }
    }
}
    


