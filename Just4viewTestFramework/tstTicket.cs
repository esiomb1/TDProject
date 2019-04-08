using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstTicket
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class clsTicket
            clsTicket ATicket = new clsTicket();
            //check to see that the class is not null
            Assert.IsNotNull(ATicket);
        }
        [TestMethod]
        public void TicketIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //create some test data to assign to the property
            Int32 TicketId = 1;
            //assign the data to the property
            ATicket.TicketId = TicketId;
            //test to see that the two value are the same
            Assert.AreEqual(ATicket.TicketId, TicketId);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //create some test data to assign to the property
            string Price = "£5";
            //assign the data to the property
            ATicket.Price = Price;
            //test to see that the two value are the same
            Assert.AreEqual(ATicket.Price, Price);
        }

        [TestMethod]
        public void TicketTypePropertyOK()
        {
            //create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //create some test data to assign to the property
            string TicketType = "Adult";
            //assign the data to the property
            ATicket.TicketType = TicketType;
            //test to see that the two value are the same
            Assert.AreEqual(ATicket.TicketType, TicketType);
        }
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeTicket = "Adult";
            //invoke the method
            Error = ATicket.Valid(SomeTicket);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

    }
}
