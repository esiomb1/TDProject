using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstAdmin
    {
        //create some test data to test against the method
        string AdminNo = "p1234";
        string Blog = "Blog1";
        string AdminEmail = "AdminEmail";
        string FirstName = "FirstName";
        string LastName = "LastName";
        private int p1234;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //test to see that it exists
            Assert.IsNotNull(AAdmin);

        }
        [TestMethod]
        public void AdminNoPropertyOK()
        {
            //create an instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //create some test data
            string TestData = "TestData";
            //assign the data to the property
            AAdmin.AdminNo = TestData;
            //test to see the that the rwo values are the same
            Assert.AreEqual(AAdmin.AdminNo, TestData);
        }
        [TestMethod]
        public void BlogPropertyOK()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create some test data to test against the property
            clsAdmin AAdmin = new clsAdmin();
            //assign the data to thw property
            ABooking.Blog = AAdmin;
            //test to see that the two values are equal
            Assert.AreEqual(ABooking.Blog, AAdmin);
        }

        [TestMethod]
        public void AdminEmailPropertyOK()
        {
            //create an instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //create some test data to test against the property
            string TestData = "AdminEmail";
            //assign the data to the property
            AAdmin.AdminEmail = TestData;
            //test to see that the two values are equal
            Assert.AreEqual(AAdmin.AdminEmail, TestData);
        }
        [TestMethod]
        public void FirstNamePorpertyOK()
        //create an instance of the class we want to create
        {
            clsAdmin AAdmin = new clsAdmin();
            //create some data to test this class against
            string FirstName = "FirstName";
            //assign the data tothe property
            AAdmin.FirstName = FirstName;
            //test to see the values are the same
            Assert.AreEqual(AAdmin.FirstName, FirstName);

        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AAdmin = new clsCustomer();
            //create some data to test
            string LastName = "LastName";
            AAdmin.LastName = LastName;
            //test to see the values are equal
            Assert.AreEqual(AAdmin.LastName, LastName);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //boolean variable to store the result of the value
            Boolean Found = false;
            //create some test data to use with the emthod
            int AdminNo = 1;
            //invoke the method
            Found = AAdmin.Find(AdminNo);
            //test to see the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestAdminNoFound()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminNo = p1234;
            //invoke the method
            Found = AAdmin.Find(AdminNo);
            //check the address no
            if (AAdmin.AdminNo != "p1234")
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
            clsAdmin AAdmin = new clsAdmin();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminNo = p1234;
            //invoke the method
            Found = AAdmin.Find(AdminNo);
            //check the address no
            if (AAdmin.FirstName != "FirstName")
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
            clsAdmin AAdmin = new clsAdmin();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminNo = p1234;
            //invoke the method
            Found = AAdmin.Find(AdminNo);
            //check the address no
            if (AAdmin.LastName != "LastName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestAdminEmailFound()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminNo = p1234;
            //invoke the method
            Found = AAdmin.Find(AdminNo);
            //check the address no
            if (AAdmin.AdminEmail != "AdminEmail")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestBlogFound()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminNo = p1234;
            //invoke the method
            Found = AAdmin.Find(AdminNo);
            //check the address no
            if (AAdmin.Blog != "Blog1")
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
            clsAdmin AAdmin = new clsAdmin();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminNo = 1;
            //invoke the method
            Found = AAdmin.Find(AdminNo);
            //check the property
            if (AAdmin.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsAdmin AnAddress = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnAddress.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AdminNoMinLessOne()
        {
            //your min less than one will be 4 here
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminNo = "1";
            AdminEmail = "admin@ceo.co.uk";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

         //   [TestMethod]
       // public void AdminEmailMax()
       // {
         //   //create an instance of the class we want to create
           // clsAdmin AAdmin = new clsAdmin();
           // //string variable to store any error message
           // String Error = "";
           // //create some test data to pass to the method
           // string AdminEmail = "";
           // AdminEmail = AdminEmail.PadRight(50, 'a');
           // AdminNo = "1";
           // Blog = "test";
            //this should be ok
            //invoke the method
          //  Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
           // Assert.AreEqual(Error, "");
      //  }

        [TestMethod]
        public void AdminNoMin()
        {
            //your min less than one will be 4 here
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminNo = "1";
            AdminEmail = "admin@ceo.co.uk";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void AdminNoMinPlusOne()
        {
            //your min less than one will be 4 here
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminNo = "123";
            AdminEmail = "admin@ceo.co.uk";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void AdminNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminNo = "123456789"; //this should be ok
            AdminEmail = "admin@ceo.co.uk";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AdminNoMax()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminNo = "1234567890"; //this should be ok
            AdminEmail = "admin@ceo.co.uk";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminNo = "12345678901"; //
            AdminEmail = "admin@ceo.co.uk";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
      
            public void AdminNoMid()
            {
                //create an instance of the class we want to create
                clsAdmin AAdmin = new clsAdmin();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string AdminNo = "12345"; //
                AdminEmail = "admin@ceo.co.uk";
                Blog = "test";
                LastName = "Last name";
                FirstName = "First name";
                //invoke the method
                Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }

        [TestMethod]
        public void AdminNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminNo = "";
            AdminEmail = "admin@ceo.co.uk";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke method
            AdminNo = AdminNo.PadRight(500, 'a'); //this should fail
            //test to see that the result is correct
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        //
        //
        //
        //begin testinng for min/max/extreme Admin Email
        [TestMethod]
        public void AdminEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminEmail = "admin@ceo.co.u";
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke method
            //AdminNo = AdminEmail.PadRight(500, 'a'); //this should fail
            //test to see that the result is correct
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminEmailMin()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminEmail = "admin@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke method
            //AdminNo = AdminEmail.PadRight(500, 'a'); //this should fail
            //test to see that the result is correct
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void AdminEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke method
            //AdminNo = AdminEmail.PadRight(500, 'a'); //this should fail
            //test to see that the result is correct
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void AdminEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminEmail = "admin@ceo.co.uk";
            AdminEmail = AdminEmail.PadRight(49, 'a');
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke method
            //AdminNo = AdminEmail.PadRight(500, 'a'); //this should fail
            //test to see that the result is correct
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AdminEmailMax()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminEmail = "admin@ceo.co.uk";
            AdminEmail = AdminEmail.PadRight(50, 'a');
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke method
            //AdminNo = AdminEmail.PadRight(500, 'a'); //this should fail
            //test to see that the result is correct
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminEmail = "";
            AdminEmail = AdminEmail.PadRight(51, 'a');
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void AdminEmailMid()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminEmail = "";
            AdminEmail = AdminEmail.PadRight(25, 'a');
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminEmail = "ceohairukadmin2019@outlook.com";
            //invoke method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminEmailInvalidData()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string AdminEmail = "this is not an email address";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //
        //
        //
        //begin testinng for min/max/extreme Admin First Name
   
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Fi";
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";

            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Fir";
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";

            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Firs";
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";

            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            LastName = "Last name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            //invoke method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameInvalidData()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string AdminEmail = "this is not a first name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// last name testing
        /// </summary>
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "La";
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            FirstName = "First name";

            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "Las";
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            FirstName = "First name";

            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNamePlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "Last";
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            FirstName = "First name";

            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            FirstName = "First name";
            //invoke method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void LastNameInvalidData()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string LastName = "this is not a first name";
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            Blog = "test";
            FirstName = "First name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        ////
        //testing for blog
        [TestMethod]
        public void BlogMinLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Blog = "Blog";
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            FirstName = "FirstName";
            LastName = "Last name";

            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BlogMin()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Blog = "Blog1";
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            FirstName = "FirstName";
            LastName = "Last name";

            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BlogMinPlusOne()
        { 
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Blog = "Blog12";
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            FirstName = "FirstName";
            LastName = "Last name";

            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void BlogMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Blog = "Blog1";
            Blog = Blog.PadRight(99, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            FirstName = "FirstName";
            LastName = "Last name";

            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void BlogMax()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Blog = "";
            Blog = Blog.PadRight(101, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            FirstName = "FirstName";
            LastName = "Last name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BlogMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Blog = "";
            Blog = Blog.PadRight(101, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            FirstName = "FirstName";
            LastName = "Last name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void BlogMidPlusOne()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Blog = "";
            Blog = Blog.PadRight(25, 'a');
            AdminEmail = "admin1@ceo.co.uk";
            AdminNo = "12345";
            FirstName = "FirstName";
            LastName = "Last name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BlogExtremeMax()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(100, 'a');
            //invoke method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BlogInvalidData()
        {
            //create an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string AdminEmail = "this is not a blog name";
            //invoke the method
            Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //[TestMethod]
        //public void AdminEmailMinPlusOne()
        //{
        //    //your min less than one will be 4 here
        //    clsAdmin AAdmin = new clsAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminNo = "ceohairuka@outlook.com";
        //    //invoke the method
        //    Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");


        //}
        //[TestMethod]
        //public void AdminEmailMaxLessOne()
        //{
        //    //create an instance of the class we want to create
        //    clsAdmin AAdmin = new clsAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminNo = "ceohairukadmi@outlook.com"; //this should be ok
        //    //invoke the method
        //    Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void AdminEmailMax()
        //{
        //    //create an instance of the class we want to create
        //    clsAdmin AAdmin = new clsAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminNo = "ceohairukadmin@outlook.com"; //this should be ok
        //    //invoke the method
        //    Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void AdminEmailMaxPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsAdmin AAdmin = new clsAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminEmail = "ceohairukadmin1@outlook.com"; //this should fail
        //    //invoke the method
        //    Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");

        //}


        //[TestMethod]
        //public void AdminEmailMid()
        //{
        //    //create an instance of the class we want to create
        //    clsAdmin AAdmin = new clsAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminEmail = "ceohairukad@outlook.com"; //this should be ok
        //                                                   //invoke the method
        //    Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void AdminEmailExtremeMax()
        //{
        //    //create an instance of the class we want to create
        //    clsAdmin AAdmin = new clsAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminEmail = "ceohairukadmin2019@outlook.com";
        //    //invoke method
        //    Error = AAdmin.Valid(AdminNo, AdminEmail, FirstName, LastName, Blog);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

    }

}






