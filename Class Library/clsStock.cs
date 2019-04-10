using System;

namespace Class_Library
{
    public class clsStock
    {
        private int mOrderNo;
        private int mQuantity; 
        public bool Active { get; set; }
        public int OrderNo
        {
            get
            {
                //return the private data 
                return mOrderNo;
            }
            set
            {
                //set the vlaue of the private data member 
                mOrderNo = value;
            }
        }
        public int Quantity
        {
            get
            {
                //return the private data 
                return mQuantity;
            }
            set
            {
                //set the vlaue of the private data member 
                mQuantity = value;
            }
        }

        public bool Find(int orderNo)
        {
            mOrderNo = 50;
            mQuantity = 1;
            return true;
        }
    }
}