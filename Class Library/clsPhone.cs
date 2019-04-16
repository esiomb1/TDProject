using System;

namespace Class_Library
{
    public class clsPhone
    {

        public bool Active
        {
            get
            {
                //return the private data 
                return mActive;
            }
            set
            {
                //set the vlaue of the private data member 
                mActive = value;
            }
        }

        public int PhoneID
        {
            get
            {
                //return the private data 
                return mPhoneID;
            }
            set
            {
                //set the vlaue of the private data member 
                mPhoneID = value;
            }
        }
        public string Colour
        {
            get
            {
                //return the private data 
                return mColour;
            }
            set
            {
                //set the vlaue of the private data member 
                mColour = value;
            }
        }

        public string PhoneMake
        {
            get
            {
                //return the private data 
                return mPhoneMake;
            }
            set
            {
                //set the vlaue of the private data member 
                mPhoneMake = value;
            }
        }
        public string PhoneModel
        {
            get
            {
                //return the private data 
                return mPhoneModel;
            }
            set
            {
                //set the vlaue of the private data member 
                mPhoneModel = value;
            }
        }
        public decimal Price
        {
            get
            {
                //return the private data 
                return mPrice;
            }
            set
            {
                //set the vlaue of the private data member 
                mPrice = value;
            }
        }

        public int StockID
        {
            get
            {
                //return the private data 
                return mStockID;
            }
            set
            {
                //set the vlaue of the private data member 
                mStockID = value;
            }
        }




        //private data member for the PhoneID
        private int mPhoneID;
        private string mColour;
        private string mPhoneMake;
        private string mPhoneModel;
        private decimal mPrice;
        private Boolean mActive;
        private int mStockID;
        public bool Find(int PhoneID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for 
            DB.AddParameter("@PhoneID", PhoneID);
            //execute the stored procedure 
            DB.Execute("sproc_tblPhone_FilterByPhoneID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mPhoneID = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneID"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mPhoneMake = Convert.ToString(DB.DataTable.Rows[0]["PhoneMake"]);
                mPhoneModel = Convert.ToString(DB.DataTable.Rows[0]["PhoneModel"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                return true;
            }

            //if no record was found 
            else
            {
                //return false indicating a problem 
                return false;





            }
        }

        public string Valid(string colour, string phoneMake, string phoneModel, string price, string stockID)
        {
            //creare a string varable to store the error 
            string Error = "";
            //if the Colour is bank
            if (Colour.Length == 0)
            {
                //record the error 
                Error = Error + "The Colour cannot be blank : ";
            }

            return Error;
        }
    }
}