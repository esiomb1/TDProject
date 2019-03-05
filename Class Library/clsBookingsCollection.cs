using System;
using System.Collections.Generic;
using System.Linq;



namespace Class_Library
{
    public class clsBookingsCollection
    {
        private List<clsBookings> mAllBookings = new List<clsBookings>();

        public clsBookingsCollection()// public contructor to the class

        {
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to geth the list of data 
            DB.Execute("sproc_tblBookings_SelectAll");
            //get the count of record 
            Int32 RecordCount = DB.Count;
            //set up the indx for the loop 
            Int32 Index = 0;
            //while there ar records to proces 
            while (Index < RecordCount)
            {
                // create an istance of the customer class 
                clsBookings ABooking = new clsBookings();
                // get the customers name 
                ABooking.FirstName = DB.DataTable.Rows[Index]["Booking"].ToString();
                //get the primar key 
                ABooking.BookingNo = Convert.ToInt32(DB.DataTable.Rows[Index]["BookingNo"]);
                //add the customer to the private data member 
                mAllBookings.Add(ABooking);
                //incriment the index
                Index++;
            }


        }


        public int Count
        {
            get
            {
                // return the count property of the private list
                return mAllBookings.Count;

            }
            set
            {
                // assign the incoming value to the private data member 

            }
        }
        public List<clsBookings> AllBookings
        {// getter send the data to requesting code
            get
            {
                // return the count property of the private list
                return mAllBookings;

            }// setter accepts data from other object
            set
            {
                // assign the incoming value to the private data member 
                mAllBookings = value;
            }
        }
    }
}