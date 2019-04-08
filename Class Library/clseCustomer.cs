using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
   public class clseCustomer
    {

        //hello 


        public string Customer { get; set; }


        private int mCustomerNo;
        private string mFirstName;
        private string mLastName;
        private string mEmailAddress;
        private string mAddress;
        private string mMobile;
        private string mPostCode;
        public bool mActive;

        public int CustomerNo
        {
            get

            {
                return mCustomerNo;
            }

            set
            { mCustomerNo = value; }
        }

        public string FirstName
        {
            get
            { return mFirstName; }

            set
            { mFirstName = value; }
        }

        public string EmailAddress
        {
            get
            { return mEmailAddress; }

            set
            { mEmailAddress = value; }
        }

        public string Mobile
        {
            get
            { return mMobile; }

            set
            { mMobile = value; }
        }

        public string LastName
        {
            get
            { return mLastName; }

            set
            { mLastName = value; }
        }

        public string PostCode
        {
            get
            { return mPostCode; }

            set
            { mPostCode = value; }
        }

        public string Address
        {
            get
            { return mAddress; }

            set
            { mAddress = value; }
        }



        public bool Active
        {
            get
            { // return the private data 
                return mActive;
            }

            set
            {
                // set the private data 
                mActive = value;

            }
        }

        public DateTime Date { get; set; }

        public bool Find(int CustomerNo)
        {
            mCustomerNo = 345;
            mFirstName = "BOB";
            mLastName = "Shakes";
            mEmailAddress = " bshakes@gmail.com";
            mAddress = "5 bunting road";
            mMobile = "0795863676";
            mPostCode = "kt6 9rj";
            mActive = true;
            // always reurn true 
            return true;
        }



        public string Valid(string someCustomer)
        {
            // string variable to store the error message 
            string Error = "";

            //if the name of the customer is more than 5 character 
            if (someCustomer.Length > 50)
            {
                //return error messgae 
                return "Customer Name Cannot Be more than 50 characters  ";

            }
            if (someCustomer.Length == 0)
            {
                //return error messgae 
                return "Customer Name Cannot Be Blank! ";

            }
            return Error;
        }
    }
}
