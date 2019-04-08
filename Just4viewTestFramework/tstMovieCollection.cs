using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstMovieCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an ninstance of the class we want to create
            clsMovieCollection AllMovies = new clsMovieCollection();
            //test to see that it exists
            Assert.IsNotNull(AllMovies);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            //create the instance of the class we want to create 
            clsMovieCollection AllMovies = new clsMovieCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllMovies.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllMovies.Count, SomeCount);


        }

        [TestMethod]
        public void AllMoviesOK()
        {
            //create an instance of the class we want to create
            clsMovieCollection Movies = new clsMovieCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsMovies> TestList = new List<clsMovies>();
            //add an item to the list
            //create the item of the test data
            clsMovies TestItem = new clsMovies();
            //set its properties
            TestItem.MovieId = 1;
            TestItem.Movie = "Shrek";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Movies.AllMovies = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Movies.AllMovies, TestList);

        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsMovieCollection Movies = new clsMovieCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsMovies> TestList = new List<clsMovies>();
            //add an item to the list
            //create the item of the test data
            clsMovies TestItem = new clsMovies();
            //set its properties
            TestItem.MovieId = 1;
            TestItem.Movie = "Shrek";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Movies.AllMovies = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Movies.Count, TestList.Count);
        }
    }
}
