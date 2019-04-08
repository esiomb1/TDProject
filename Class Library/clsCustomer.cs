using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsCustomer
    {
        //prvate data member for the CustomerNo property
        private Int32 mCustomerNo;
        //private data member for Addresss
        private string mAddress;
        //private data member for DateOfBirth
        private DateTime mDateOfBirth;
        //private data member for Email
        private string mEmail;
        //private data member for LastName
        private string mLastName;
        //private data member FirstName
        private string mFirstName;
        //private data member Title
        private string mTitle;
        //private data member postcode
        private string mPostcode;
        //private data memeber mobile
        private string mMobile;

        //private data member for active
        private bool mActive;
        //public property for active
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        //public property for mobile

        public string Mobile
        {
            get
            {
                //return private data
                return mMobile;
            }
            set
            {
                //set the private data 
                mMobile = value;
            }
        }

        //public property for postcode

        public string Postcode
        {
            get
            {
                return mPostcode;
            }
            set
            {
                //set the private data
                mPostcode = value;
            }
        }

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }   
        }
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string FirstName
        {
            get
            {
                return mFirstName;
            }

            set
            {
                mFirstName = value;
            }
        }

        public string Title
        {
            get
            {
                return mTitle;
            }
            set
            {
                mTitle = value;
            }
        }

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public int CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }
        }
 
        public bool Find(int customerNo)
        {
            throw new NotImplementedException();
        }
    }
}
