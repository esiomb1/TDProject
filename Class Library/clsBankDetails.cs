using System;

namespace Class_Library
{
    public class clsBankDetails
    {

        //private data member for the BankID property
        private int mBankID;
        private string mBankCardName;
        private Int64 mBankCardNumber;
        private int mCustomerID;
        private int mCVCDigits;
        private DateTime mExpiryDate;
        private int mSortCode;
        public int BankID
        {
            get
            {
                //return the private data 
                return mBankID;
            }
            set
            {
                //set the value of the private data member 
                mBankID = value;
            }
        }
        public string BankCardName
        {
            get
            {
                //return the private data 
                return mBankCardName;
            }
            set
            {
                //set the value of the private data member 
                mBankCardName = value;
            }
        }
        public long BankCardNumber
        {
            get
            {
                //return the private data 
                return mBankCardNumber;
            }
            set
            {
                //set the value of the private data member 
                mBankCardNumber = value;
            }
        }
        public int CustomerID
        {
            get
            {
                //return the private data 
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member 
                mCustomerID = value;
            }
        }
        public int CVCDigits
        {
            get
            {
                //return the private data 
                return mCVCDigits;
            }
            set
            {
                //set the value of the private data member 
                mCVCDigits = value;
            }
        }
        public DateTime ExpiryDate
        {
            get
            {
                //return the private data 
                return mExpiryDate;
            }
            set
            {
                //set the value of the private data member 
                mExpiryDate = value;
            }
        }
        public int SortCode
        {
            get
            {
                //return the private data 
                return mSortCode;
            }
            set
            {
                //set the value of the private data member 
                mSortCode = value;
            }
        }

        

        public bool Find(int AdministratorID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the bank id to search for 
            DB.AddParameter("@BankID", BankID);
            //execute the stored procedure 
            DB.Execute("[sproc_tblBankDetails_FilterByBankID]");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mBankID = Convert.ToInt32(DB.DataTable.Rows[0]["BankID"]);
                mBankCardName = Convert.ToString(DB.DataTable.Rows[0]["BankCardName"]);
                mBankCardNumber = Convert.ToInt32(DB.DataTable.Rows[0]["BankCardNumber"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCVCDigits = Convert.ToInt32(DB.DataTable.Rows[0]["CVCDigits"]);
                mExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExpiryDate"]);
                mSortCode = Convert.ToInt32(DB.DataTable.Rows[0]["SortCode"]);

                return true;
            }

            //if no record was found 
            else
            {
                //return false indicating a problem 
                return false;


            }
        }
    }
}