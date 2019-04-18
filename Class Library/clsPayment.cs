using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsPayment
    {
        //private data member for the cardno property
        private Int32 mCardNo;
        //private data member for cvv number
        private Int32 mCVVNo;
        //private data member for date of birth
        private DateTime mExpiryDate;
        //private data member for email
        private string mEmail;

        //private data member for active
        private bool mActive;

        //public property for active
        public bool Active;
        public int CardNo
        {
            get
            {
                return mCardNo;
            }
            set
            {
                mCardNo = value;
            }
        }

        public int CVVNo
        {
            get
            {
                return mCVVNo;
            }
            set
            {
                mCVVNo = value;

            }
        }

        public DateTime ExpiryDate
        {
            get
            {
                return mExpiryDate;
            }
            set
            {
                mExpiryDate = value;
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
    }