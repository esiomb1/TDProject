using System.Collections.Generic;

namespace Class_Library
{
    public class clsOrderCollection
    {
        //private data member for the allOrders
        private List<clsOrder> mAllOrders = new List<clsOrder>();
        public int Count
        {
            get
            {
                //return the count property of the private list 
                return mAllOrders.Count;
            }
            set
            {
                //we will look atthis in a moment 
            }
        }
        public List<clsOrder> AllOrders
        {
            get
            {
                //return the private data member 
                return mAllOrders;
            }
            //setter accepts data fom other objects 
            set
            {
                //assign the incoming value to the private data member 
                mAllOrders = value;

            }
        }

            //public constructor for the class 
            public clsOrderCollection()
        {
            //create an instance of the order class to store a order 
            clsOrder AOrder = new clsOrder();
            //set the orderNo to 122332
            AOrder.Order = "O122332";
            //add the order to the private list of Orders 
            mAllOrders.Add(AOrder);
            //re initalise the AOrder object to accept a new item 
            AOrder = new clsOrder();
            // set the order to O122332
            AOrder.Order = "O1223434";
            //add the second order to the private list of orders 
            mAllOrders.Add(AOrder);

        }



    }
}
