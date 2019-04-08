using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstMovies
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class clsMovies
            clsMovies AnMovies = new clsMovies();
            //check to see that the class is not null
            Assert.IsNotNull(AnMovies);
        }


        [TestMethod]
        //used to test the movie property of the class
        public void MoviePropertyOK()
        {
            //create an instance of the class
            clsMovies AMovie = new clsMovies();
            //create some test data to assign to the property
            string SomeMovie = "Shrek";
            //assign the data to the property
            AMovie.Movie = SomeMovie;
            //test to see that the two values are the same
            Assert.AreEqual(AMovie.Movie, SomeMovie);
        }

        [TestMethod]
       public void MovieIdPropertyOK()
        {
          //create an instance of the class we want to create
          clsMovies AMovie = new clsMovies();
           //create some test data to assign to the property
           Int32 MovieId = 1;
            //assign the data to the property
            AMovie.MovieId = MovieId;
            //test to see that the two value are the same
            Assert.AreEqual(AMovie.MovieId, MovieId);
}

        [TestMethod]
        public void DateReleasedPropertyOK()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create some test data to assign to the property
            int DateReleased = 01/12/2017;
            //assign the data to the property
            AMovie.DateReleased = DateReleased;
            //test to see that the two value are the same
            Assert.AreEqual(AMovie.DateReleased, DateReleased);
        }

        [TestMethod]
        public void DirectorPropertyOK()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create some test data to assign to the property
            string Director = "John Seagul";
            //assign the data to the property
            AMovie.Director = Director;
            //test to see that the two value are the same
            Assert.AreEqual(AMovie.Director, Director);
        }


        [TestMethod]
        public void CategoryPropertyOK()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create some test data to assign to the property
            string Category = "Action";
            //assign the data to the property
            AMovie.Category = Category;
            //test to see that the two value are the same
            Assert.AreEqual(AMovie.Category, Category);
        }

        [TestMethod]
        public void RunTimePropertyOK()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create some test data to assign to the property
            string RunTime = "1hr 20mins";
            //assign the data to the property
            AMovie.RunTime = RunTime;
            //test to see that the two value are the same
            Assert.AreEqual(AMovie.RunTime, RunTime);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeMovie = "Shrek";
            //invoke the method
            Error = AMovie.Valid(SomeMovie);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MovieMinLessOne()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeMovie = "";
            //invoke the method
            Error = AMovie.Valid(SomeMovie);
            //test to see that the result is NOT OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MovieMinBoundary()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeMovie = "a";
            //invoke the method
            Error = AMovie.Valid(SomeMovie);
            //test to see that the result is NOT OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MovieMinPlusOne()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeMovie = "aa";
            //invoke the method
            Error = AMovie.Valid(SomeMovie);
            //test to see that the result is NOT OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MovieMaxLessOne()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeMovie = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = AMovie.Valid(SomeMovie);
            //test to see that the result is NOT OK
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MovieMaxBoundary()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeMovie = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = AMovie.Valid(SomeMovie);
            //test to see that the result is NOT OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MovieMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeMovie = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = AMovie.Valid(SomeMovie);
            //test to see that the result is NOT OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MovieMid()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeMovie = "0123456789012345678901234";
            //invoke the method
            Error = AMovie.Valid(SomeMovie);
            //test to see that the result is NOT OK
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MovieExtremeMax()
        {
            //create an instance of the class we want to create
            clsMovies AMovie = new clsMovies();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeMovie = "";
            //pad the string with characters
            SomeMovie = SomeMovie.PadRight(500, 'a');
            //invoke the method
            Error = AMovie.Valid(SomeMovie);
            //test to see that the result is NOT OK
            Assert.AreNotEqual(Error, "");
        }
    }
}

    
    