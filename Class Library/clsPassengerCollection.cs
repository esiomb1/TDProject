using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsPassengerCollection
    {
        private List<clsPassenger> mAllPassengers = new List<clsPassenger>();

        public clsPassengerCollection()// public contructor to the class

        {
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to geth the list of data 
            DB.Execute("sproc_tblPassenger_SelectAll");
            //get the count of record 
            Int32 RecordCount = DB.Count;
            //set up the indx for the loop 
            Int32 Index = 0;
            //while there ar records to proces 
            while (Index < RecordCount)
            {
                // create an istance of the customer class 
                clsPassenger APassenger = new clsPassenger();
                // get the customers name 
                APassenger.Passenger = DB.DataTable.Rows[Index]["Passenger"].ToString();
                //get the primar key 
                APassenger.PassengerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PassengerNo"]);
                //add the customer to the private data member 
                mAllPassengers.Add(APassenger);
                //incriment the index
                Index++;
            }


        }


        public int Count
        {
            get
            {
                // return the count property of the private list
                return mAllPassengers.Count;

            }
            set
            {
                // assign the incoming value to the private data member 

            }
        }
        public List<clsPassenger> AllPassengers
        {// getter send the data to requesting code
            get
            {
                // return the count property of the private list
                return mAllPassengers;

            }// setter accepts data from other object
            set
            {
                // assign the incoming value to the private data member 
                mAllPassengers = value;
            }
        }
    }
}