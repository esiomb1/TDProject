using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsFlightsCollection
    {

       
        private List<clsFlights> mAllFlights = new List<clsFlights>();

        public clsFlightsCollection()// public contructor to the class

        {
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to geth the list of data 
            DB.Execute("sproc_tblFlights_SelectAll"); // check the name of tblflights
            //get the count of record 
            Int32 RecordCount = DB.Count;
            //set up the indx for the loop 
            Int32 Index = 0;
            //while there ar records to proces 
            while (Index < RecordCount)
            {
                // create an istance of the customer class 
                clsFlights AFlight = new clsFlights();
                //get the primar key 
                AFlight.FlightNo = Convert.ToInt32(DB.DataTable.Rows[Index]["FlightNo"]);
                //add the customer to the private data member 
                mAllFlights.Add(AFlight);
                //incriment the index
                Index++;
            }


        }


        public int Count
        {
            get
            {
               // return the count property of the private list
                return mAllFlights.Count;

            }
    set
            {
               //  assign the incoming value to the private data member

            }
        }
        public List<clsFlights> AllFlights
        {// getter send the data to requesting code
            get
            {
                // return the count property of the private list
                return mAllFlights;

            }// setter accepts data from other object
            set
            {
                // assign the incoming value to the private data member 
                mAllFlights = value;
            }
        }


        private List<clsWidget> mWidgets = new List<clsWidget>();


        public List<clsWidget> Widgets
        {
            get
            {
                return mWidgets;
            }
        }

        //public Int32 Count
        //{
        //    get
        //    {
        //        return mWidgets.Count;
        //    }
        //}


        public void AvailableFlights(DateTime StartDate, DateTime EndDate)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StartDate", StartDate);
            DB.AddParameter("@EndDate", EndDate);
            DB.Execute("sproc_tblFlights_CheckAvailablity");
            mWidgets = new List<clsWidget>();
            Int32 Index = 0;
            Int32 Count = DB.Count;
            while ( Index < Count)
            {
                clsWidget Aflight = new clsWidget();
                Aflight.WidgetNo = Convert.ToInt32(DB.DataTable.Rows[Index]["WidgetNo"]);
                Aflight.Widget = Convert.ToString(DB.DataTable.Rows[Index]["Widget"]);
                mWidgets.Add(Aflight);
                Index++; 
            }
        }
    }

 }
