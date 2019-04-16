using System;

namespace Class_Library
{
    public class clsPhoneCustomer
    {
        

        //private data member for the PhoneID
        private int mPhoneCustomerNo;
        public int mCustomerID;
        public string mFirstName;
        private string mSurname;
        private string mPostcode;
        public string mAddress;
        public Boolean mActive;


        public int PhoneCustomerNo
        {
            get
            {
                //return the private data 
                return mPhoneCustomerNo;
            }
            set
            {
                //set the vlaue of the private data member 
                mPhoneCustomerNo = value;
            }

        }
        public string Address
        {
            get
            {
                //return the private data 
                return mAddress;
            }
            set
            {
                //set the vlaue of the private data member 
                mAddress = value;
            }

        }

        public string FirstName
        {
            get
            {
                //return the private data 
                return mFirstName;
            }
            set
            {
                //set the vlaue of the private data member 
                mFirstName = value;
            }
        }




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

        public string Surname
        {
            get
            {
                //return the private data 
                return mSurname;
            }
            set
            {
                //set the vlaue of the private data member 
                mSurname = value;
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
                //set the vlaue of the private data member 
                mCustomerID = value;
            }
        }

        public string Postcode
        {
            get
            {
                //return the private data 
                return mPostcode;
            }
            set
            {
                //set the vlaue of the private data member 
                mPostcode = value;
            }
        }

        public string Valid(object customerID, object firstName, object surname, object address, object postcode)
        {
            return "";
        }

        public string Valid(string someAPhoneCustomer)
        {
            //string variable to store the error message 
            string Error = "";
            //if the name of the PhoneCustomer is not blank 
            if (someAPhoneCustomer.Length > 50)
            {
                //return an Error Message
                Error = "The Customer name cannot have more than 50 character";
            }
            if (someAPhoneCustomer.Length == 0)
            {
                //otherwise return an error message 
                Error = "The Customer name may not be blank!";
            }
            return Error;
        }



        public bool Find(int CustomerID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for 
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure 
            DB.Execute("sproc_tblPhoneCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
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