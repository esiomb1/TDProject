using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstBankDetails
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //test to see that it exists 
            Assert.IsNotNull(ABankDetails);
        }

        //    [TestMethod]
        //    public void ActivePropertyOK()
        //    {
        //        create an instance of the class we want to create
        //        clsBankDetails ABankDetails = new clsBankDetails();
        //    create some test data to assign to the property
        //    Boolean TestData = true;
        //        assign the data to the property
        //        ABankDetails.Active = TestData;
        //        test to se that the two values are the same
        //        Assert.AreEqual(ABankDetails.Active, TestData)
        //}



        [TestMethod]
        public void BankIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //create some test data to assign to the property
            int TestData = 30;
            //assign the data to the property
            ABankDetails.BankID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ABankDetails.BankID, TestData);
        }


        [TestMethod]
        public void BankCardNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //create some test data to assign to the property
            String TestData = "Ben";
            //assign the data to the property
            ABankDetails.BankCardName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ABankDetails.BankCardName, TestData);
        }



        [TestMethod]
        public void BankCardNumberPropertyOK()
        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //create some test data to assign to the property
            Int64 TestData = 0923245367438217;
            //assign the data to the property
            ABankDetails.BankCardNumber = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ABankDetails.BankCardNumber, TestData);
        }


        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            ABankDetails.CustomerID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ABankDetails.CustomerID, TestData);
        }



        [TestMethod]
        public void CVCDigitsPropertyOK()
        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //create some test data to assign to the property
            int TestData = 674;
            //assign the data to the property
            ABankDetails.CVCDigits = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ABankDetails.CVCDigits, TestData);
        }

        [TestMethod]
        public void ExpiryDatePropertyOK()
        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ABankDetails.ExpiryDate = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ABankDetails.ExpiryDate, TestData);
        }

        [TestMethod]
        public void SortCodePropertyOK()
        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //create some test data to assign to the property
            int TestData = 124365;
            //assign the data to the property
            ABankDetails.SortCode = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ABankDetails.SortCode, TestData);
        }

        [TestMethod]
        public void FindMethodOK()

        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            int BankID = 30;
            //invoke the method 
            Found = ABankDetails.Find(BankID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);


        }

        [TestMethod]
        public void FindBankCardNameFound()

        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            int BankID = 30;
            //invoke the method 
            Found = ABankDetails.Find(BankID);
            //check the bankID
            if (ABankDetails.BankCardName != "Ben")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void FindBankCardNumberFound()

        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            int BankID = 30;
            //invoke the method 
            Found = ABankDetails.Find(BankID);
            //check the bankID
            if (ABankDetails.BankCardNumber != 0923245367438217)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);


        }


        [TestMethod]
        public void FindCustomerIDFound()

        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            int BankID = 30;
            //invoke the method 
            Found = ABankDetails.Find(BankID);
            //check the bankID
            if (ABankDetails.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void FindCVCDigitsFound()

        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            int BankID = 30;
            //invoke the method 
            Found = ABankDetails.Find(BankID);
            //check the bankID
            if (ABankDetails.CVCDigits != 674)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);


        }


        [TestMethod]
        public void FindExpiryDateFound()

        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            int BankID = 30;
            //invoke the method 
            Found = ABankDetails.Find(BankID);
            //check the bankID
            if (ABankDetails.ExpiryDate !=Convert.ToDateTime("03/04/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);


        }


        [TestMethod]
        public void FindSortCodeFound()

        {
            //create an instance of the class we want to create 
            clsBankDetails ABankDetails = new clsBankDetails();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            int BankID = 30;
            //invoke the method 
            Found = ABankDetails.Find(BankID);
            //check the bankID
            if (ABankDetails.SortCode != 124365)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);


        }








    }


}