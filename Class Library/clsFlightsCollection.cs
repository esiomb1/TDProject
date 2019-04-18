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
        //private data member thisAddress
        clsFlights mThisFlight = new clsFlights();

      //  /private data member for the list
        List<clsFlights> mFlightsList = new List<clsFlights>();

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

     
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count; clsFlights
          //clear the private array list
          mFlightsList = new List<clsFlights>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsFlights AFlight = new clsFlights();
                //read in the fields from the current record

                AFlight.FlightNo = Convert.ToInt32(DB.DataTable.Rows[Index]["FlightNo"]);
                AFlight.DepartureAirport = Convert.ToString(DB.DataTable.Rows[Index]["DepartureAirport"]);
                AFlight.ArrivalDestination = Convert.ToString(DB.DataTable.Rows[Index]["ArrivalDestination"]);
                AFlight.DepartureTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["DepartureTime"]);
                AFlight.ArrivalTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["ArrivalTime"]);
                AFlight.Cost = Convert.ToString(DB.DataTable.Rows[Index]["Cost"]);
                AFlight.Duration = Convert.ToDateTime(DB.DataTable.Rows[Index]["Duration"]);
                //add the record to the private data mamber
                mFlightsList.Add(AFlight);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FlightNo", mThisFlight.FlightNo);
            DB.AddParameter("@DepartureAirport", mThisFlight.DepartureAirport);
            DB.AddParameter("@ArrivalDestination", mThisFlight.ArrivalDestination);
            DB.AddParameter("@DepartureTime", mThisFlight.DepartureTime);
            DB.AddParameter("@ArrivalTime ", mThisFlight.ArrivalTime);
            DB.AddParameter("@Cost", mThisFlight.Cost);
            DB.AddParameter("@Duration", mThisFlight.Duration);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblFlights_Insert");
        }


        //public property for the address list
        public List<clsFlights> FlightsList
        {
            get
            {
                //return the private data
                return mFlightsList;
            }
            set
            {
                //set the private data
                mFlightsList = value;
            }
        }


        public clsFlights ThisFlight
        {
            get
            {
                //return the private data
                return mThisFlight;
            }
            set
            {
                //set the private data
                mThisFlight = value;
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
