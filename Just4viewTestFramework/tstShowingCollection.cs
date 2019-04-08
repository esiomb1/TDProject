using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstShowingCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsShowingCollection AllShowings = new clsShowingCollection();
            //test to see that it exists
            Assert.IsNotNull(AllShowings);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create the instance of the class we want to create 
            clsShowingCollection AllShowings = new clsShowingCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllShowings.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllShowings.Count, SomeCount);
        }

        [TestMethod]
        public void AllShowingOK()
        {
            //create an instance of the class we want to create
            clsShowingCollection Showing = new clsShowingCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsShowing> TestList = new List<clsShowing>();
            //add an item to the list
            //create the item of the test data
            clsShowing TestItem = new clsShowing();
            //set its properties
            TestItem.ShowingId = 1;
            TestItem.ShowingName = "Shrek";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Showing.AllShowing = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Showing.AllShowing, TestList);
        }
    }
}