using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        public object ACustomer { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void ActiveOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean Active = true;
            //assign
            ACustomer.Active= Active;
            Assert.AreEqual(ACustomer.Active, Active);
        }

        //create new test here
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeAddress = "1 Tudor Road SE12 9BH";
            //assign
            ACustomer.Address = SomeAddress;
            Assert.AreEqual(ACustomer.Address, SomeAddress);
        }
        [TestMethod]

        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //int CustomerNo = 0;
            //create some test data to assign to the property
            Int32 CustomerNo = 1;
            //assign the data to the property
            ACustomer.CustomerNo = CustomerNo;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, CustomerNo);
        }
        [TestMethod]
        public void DateOfBirthOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some data to test against
            DateTime DateOfBirth = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = DateOfBirth;
            //twst to see the values are equal
            Assert.AreEqual(ACustomer.DateOfBirth, DateOfBirth);
        }

        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some data to test
            string Email = "Email";
            //assign the data to the property
            ACustomer.Email = Email;
            //test to see the values are the same
            Assert.AreEqual(ACustomer.Email, Email);
        }
        [TestMethod]
        public void FirstNameOK()
        //create an instance of the class we want to create
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some data to test this class against
            string FirstName = "FirstName";
            //assign the data t the property
            ACustomer.FirstName = FirstName;
            //test to see the values are the same
            Assert.AreEqual(ACustomer.FirstName, FirstName);

        }
        [TestMethod]
        public void LastNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some data to test
            string LastName = "LastName";
            ACustomer.LastName = LastName;
            //test to see the values are equal
            Assert.AreEqual(ACustomer.LastName, LastName);
        }

        [TestMethod]
        public void TitleOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some data to test
            string Title = "Title";
            ACustomer.Title = Title;
            //tests to see the values are equal
            Assert.AreEqual(ACustomer.Title, Title);
        }
        [TestMethod]
        public void PostcodeOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some data
            string Postcode = "Postcode";
            ACustomer.Postcode = Postcode;
            //tests to see the values are equal
            Assert.AreEqual(ACustomer.Postcode, Postcode);
        }

        [TestMethod]

        public void MobileOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some data
            string Mobile = "Mobile";
            ACustomer.Mobile = Mobile;
            //tests to see the values are equal
            Assert.AreEqual(ACustomer.Mobile, Mobile);
        }

        [TestMethod]
        public bool Find(int CustomerNo)
        {
            //always return teuw
            return true;

        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store theresult of the search
            Boolean Found = false;
            //boolean variable recod if data is ok
            Boolean OK = true;
            //create some test data o use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.CustomerNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store theresult of the search
            Boolean Found = false;
            //boolean variable recod if data is ok
            Boolean OK = true;
            //create some test data o use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.Address != "Test Address")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store theresult of the search
            Boolean Found = false;
            //boolean variable recod if data is ok
            Boolean OK = true;
            //create some test data o use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.DateOfBirth != Convert.ToDateTime("16/09/1996"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store theresult of the search
            Boolean Found = false;
            //boolean variable recod if data is ok
            Boolean OK = true;
            //create some test data o use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.Email != "Test Email")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store theresult of the search
            Boolean Found = false;
            //boolean variable recod if data is ok
            Boolean OK = true;
            //create some test data o use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.FirstName != "Test FirstName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store theresult of the search
            Boolean Found = false;
            //boolean variable recod if data is ok
            Boolean OK = true;
            //create some test data o use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.LastName != "Test LastName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestMobileFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store theresult of the search
            Boolean Found = false;
            //boolean variable recod if data is ok
            Boolean OK = true;
            //create some test data o use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.Mobile != "Test Mobile")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store theresult of the search
            Boolean Found = false;
            //boolean variable recod if data is ok
            Boolean OK = true;
            //create some test data o use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.Postcode != "Test PostCode")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTitleFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store theresult of the search
            Boolean Found = false;
            //boolean variable recod if data is ok
            Boolean OK = true;
            //create some test data o use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.Title != "Test Title")
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
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store theresult of the search
            Boolean Found = false;
            //boolean variable recod if data is ok
            Boolean OK = true;
            //create some test data o use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
        