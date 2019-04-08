using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstShowing
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class clsMovies
            clsShowing AnShowing = new clsShowing();
            //check to see that the class is not null
            Assert.IsNotNull(AnShowing);
        }


        [TestMethod]
        public void ShowingIdPropertyOk()
        {
            //create an instance of the class
            clsShowing AShowing = new clsShowing();
            //create some test data to assign to the property
            Int32 ShowingId = 1;
            //assign the data to the property
            AShowing.ShowingId = ShowingId;
            //test to see that the two value are the same
            Assert.AreEqual(AShowing.ShowingId, ShowingId);
        }

        [TestMethod]
        //used to test the movie property of the class
        public void ShowingNamePropertyOK()
        {
            //create an instance of the class
            clsShowing AShowing = new clsShowing();
            //create some test data to assign to the property
            string SomeShowing = "Shrek";
            //assign the data to the property
            AShowing.ShowingName = SomeShowing;
            //test to see that the two values are the same
            Assert.AreEqual(AShowing.ShowingName, SomeShowing);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsShowing AShowing = new clsShowing();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeShowing = "Shrek";
            //invoke the method
            Error = AShowing.Valid(SomeShowing);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }
    }
}