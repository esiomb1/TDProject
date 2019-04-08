using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstBlog
    //create some test data to test against the method
    {
        string BlogNo = "Blog1";
        string BlogDescription = "Blog1 hair colouring";
        string Email = "AdminEmail";
        string DateReleased ="01/02/2019";

        private int p1234;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsBlog ABlog = new clsBlog();
            //test to see that it exists
            Assert.IsNotNull(ABlog);

        }
        [TestMethod]
        public void BlogNoPropertyOK()

        {
            //create an instance of the class we want to create
            clsBlog ABlog = new clsBlog();
            //create some data to test the property
            int TestData = 1;
            //assign the data to the property
            ABlog.BlogNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ABlog.BlogNo, TestData);
        }
        [TestMethod]
        public void BlogDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsBlog ABlog = new clsBlog();
            //create some data to test the property
            string TestData = "BlogDescription";
            //assign the data to property
            ABlog.BlogDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ABlog.BlogDescription, TestData);
        }
        [TestMethod]
        public void DateReleasedPropertyOK()
        {
            //create an instance of the class
            clsBlog ABlog = new clsBlog();
            //create some data to test the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ABlog.DateReleased = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ABlog.DateReleased, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class
            clsBlog ABlog = new clsBlog();
            //create some data to test the property
            string TestData = "Email";
            //assign the data to the property
            ABlog.Email = TestData;
            //test to see that the values are equal
            Assert.AreEqual(ABlog.Email, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsBlog Ablog = new clsBlog();
            //boolean variable to store the result of the value
            Boolean Found = false;
            //create some test data to use with the method
            int BlogNo = 1;

            //invoke the method
            Found = Ablog.Find(BlogNo);
            //test to see the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestBlogNoFound()
        {
            //create an instance of the class we want to create
            clsBlog Ablog = new clsBlog();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BlogNo = 1;
            //invoke the method
            Found = Ablog.Find(BlogNo);
            //check the address no
            if (Ablog.BlogNo != 1)
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
            clsBlog ABlog = new clsBlog();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BlogNo = 1;
            //invoke the method
            Found = ABlog.Find(BlogNo);
            //check the address no
            if (ABlog.Email != "adminEmail")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void BlogMinLessOne()
        {
            //create an instance of the class we want to create
            clsBlog ABlog = new clsBlog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BlogNo = "Blog";
            BlogDescription = "Blog1, hair coluring";
            Email = "AdminEmail";
            DateReleased = "01/02/2019";


            //invoke the method
            Error = ABlog.Valid(BlogNo, BlogDescription, Email, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BlogNoMin()
        {
            //your min less than one will be 4 here
            clsBlog ABlog = new clsBlog();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BlogNo = "Blog1";
            BlogDescription = "Blog1, hair coluring";
            Email = "AdminEmail";
            DateReleased = "01/02/2019";
            //invoke the method
            Error = ABlog.Valid(BlogNo, BlogDescription, Email, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

    }
}

       