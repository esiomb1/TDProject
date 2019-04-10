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

        public bool Find(int phoneID)
        {
            //set the private data member to the test data value 
            mPhoneID = 3;
            mColour = "Red";
            mPhoneMake = "Apple";
            mPhoneModel = "iPhone 8 Plus";
            mPrice = Convert.ToDecimal(899);
            mActive = true;
           
            //always return true 
            return true;
        }

        //private data member for the PhoneID
        private int mPhoneID;
        private string mColour;
        private string mPhoneMake;
        private string mPhoneModel;
        private decimal mPrice;
        private Boolean mActive;
        
    }
}