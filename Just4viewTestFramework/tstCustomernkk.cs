using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomernkk
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class clsMovies
            clsCustomernkk AnCustomer = new clsCustomernkk();
            //check to see that the class is not null
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class
            clsCustomernkk ACustomer = new clsCustomernkk();
            //create some test data to assign to the property
            string SomeCustomer = "James";
            //assign the data to the property
            ACustomer.Name = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Name, SomeCustomer);

        }

        [TestMethod]
        public void MobilePropertyOK()
        {
            //create an instance of the class
            clsCustomernkk ACustomer = new clsCustomernkk();
            //create some test data to assign to the property
            string SomeCustomer = "07896857634";
            //assign the data to the property
            ACustomer.Mobile = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Mobile, SomeCustomer);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomernkk ACustomer = new clsCustomernkk();
            //create some test data to assign to the property
            Int32 CustomerId = 1;
            //assign the data to the property
            ACustomer.CustomerId = CustomerId;
            //test to see that the two value are the same
            Assert.AreEqual(ACustomer.CustomerId, CustomerId);
        }

        public void EmailPropertyOK()
        {
            //create an instance of the class
            clsCustomernkk ACustomer = new clsCustomernkk();
            //create some test data to assign to the property
            string SomeCustomer = "john@gmail.com";
            //assign the data to the property
            ACustomer.Email = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, SomeCustomer);
        }
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class
            clsCustomernkk ACustomer = new clsCustomernkk();
            //create some test data to assign to the property
            string SomeCustomer = "04/01/1990";
            //assign the data to the property
            ACustomer.DateOfBirth = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, SomeCustomer);
        }
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomernkk ACustomer = new clsCustomernkk();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCustomer = "James";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomer);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }
    }
}