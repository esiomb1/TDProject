using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCinema
    {

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class clsMovies
            clsCinema AnCinema = new clsCinema();
            //check to see that the class is not null
            Assert.IsNotNull(AnCinema);
        }
        [TestMethod]
        public void CinemaPropertyOK()
        {
            //create an instance of the class
            clsCinema ACinema = new clsCinema();
            //create some test data to assign to the property
            string SomeCinema = "Leicester";
            //assign the data to the property
            ACinema.Cinema = SomeCinema;
            //test to see that the two values are the same
            Assert.AreEqual(ACinema.Cinema, SomeCinema);

        }

        [TestMethod]
        public void CinemaIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCinema ACinema = new clsCinema();
            //create some test data to assign to the property
            Int32 CinemaId = 1;
            //assign the data to the property
            ACinema.CinemaId = CinemaId;
            //test to see that the two value are the same
            Assert.AreEqual(ACinema.CinemaId, CinemaId);

        }
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsCinema ACinema = new clsCinema();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCinema = "Leicester";
            //invoke the method
            Error = ACinema.Valid(SomeCinema);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CinemaMinLessOne()
        {
            //create an instance of the class we want to create
            clsCinema ACinema = new clsCinema();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCinema = "";
            //invoke the method
            Error = ACinema.Valid(SomeCinema);
            //test to see that the result is NOT OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CinemaMinBoundary()
        {
            //create an instance of the class we want to create
            clsCinema ACinema = new clsCinema();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCinema = "a";
            //invoke the method
            Error = ACinema.Valid(SomeCinema);
            //test to see that the result is NOT OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CinemaMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCinema ACinema = new clsCinema();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCinema = "aa";
            //invoke the method
            Error = ACinema.Valid(SomeCinema);
            //test to see that the result is NOT OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CinemaMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCinema ACinema = new clsCinema();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCinema = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = ACinema.Valid(SomeCinema);
            //test to see that the result is NOT OK
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CinemaMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCinema ACinema = new clsCinema();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCinema = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = ACinema.Valid(SomeCinema);
            //test to see that the result is NOT OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CinemaMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCinema ACinema = new clsCinema();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCinema = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = ACinema.Valid(SomeCinema);
            //test to see that the result is NOT OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CinemaMid()
        {
            //create an instance of the class we want to create
            clsCinema ACinema = new clsCinema();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCinema = "0123456789012345678901234";
            //invoke the method
            Error = ACinema.Valid(SomeCinema);
            //test to see that the result is NOT OK
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CinemaExtremeMax()
        {
            //create an instance of the class we want to create
            clsCinema ACinema = new clsCinema();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCinema = "";
            //pad the string with characters
            SomeCinema = SomeCinema.PadRight(500, 'a');
            //invoke the method
            Error = ACinema.Valid(SomeCinema);
            //test to see that the result is NOT OK
            Assert.AreNotEqual(Error, "");
        }
    }
}

    
