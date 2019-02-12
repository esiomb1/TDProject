using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
   public class clsItineraryCollection
    { 
        private List<clsItinerary> mAllItineraries = new List<clsItinerary>();

    public clsItineraryCollection()// public contructor to the class

    {
        // create an instance of the data connection 
        clsDataConnection DB = new clsDataConnection();
        //execute the stored procedure to geth the list of data 
        DB.Execute("sproc_tblItinerary_SelectAll");
        //get the count of record 
        Int32 RecordCount = DB.Count;
        //set up the indx for the loop 
        Int32 Index = 0;
        //while there ar records to proces 
        while (Index < RecordCount)
        {
                // create an istance of the customer class 
                clsItinerary AnItinerary = new clsItinerary();
                // get the customers name 
                AnItinerary.Itinerary = DB.DataTable.Rows[Index]["Itinerary"].ToString();
                //get the primar key 
                AnItinerary.ItineraryNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ItineraryNo"]);
                //add the customer to the private data member 
                mAllItineraries.Add(AnItinerary);
            //incriment the index
            Index++;
        }


    }


    public int Count
    {
        get
        {
            // return the count property of the private list
            return mAllItineraries.Count;

        }
        set
        {
            // assign the incoming value to the private data member 

        }
    }
    public List<clsItinerary> AllItineraries
        {// getter send the data to requesting code
        get
        {
            // return the count property of the private list
            return mAllItineraries;

        }// setter accepts data from other object
        set
        {
                // assign the incoming value to the private data member 
                mAllItineraries = value;
        }
    }
}
}
