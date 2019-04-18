using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsFlights
    {
        // private data member for the flight no prop
        private Int32 mFlightNo;


        public int FlightNo
        {
            get
            {
                // return the private data 
                return mFlightNo;
            }
            set
            {
                //set he value of the private data memebr 
                mFlightNo = value;
            }
        }


        private string mDepartureDestination;
        public string DepartureDestination
        {
            get
            {
                // return the private data 
                return mDepartureDestination;
            }
            set
            {
                //set he value of the private data memebr 
                mDepartureDestination = value;
            }
        }
        private string mDepartureAirport;
        public string DepartureAirport
        {
            get
            {
                // return the private data 
                return mDepartureAirport;
            }
            set
            {
                //set he value of the private data memebr 
                mDepartureAirport = value;
            }
        }
        private string mArrivalAirport;
        public string ArrivalAirport
        {
            get
            {
                // return the private data 
                return mArrivalAirport;
            }
            set
            {
                //set he value of the private data memebr 
                mArrivalAirport = value;
            }
        }
        private string mArrivalDestination;
        public string ArrivalDestination
        {
            get
            {
                // return the private data 
                return mArrivalDestination;
            }
            set
            {
                //set he value of the private data memebr 
                mArrivalDestination = value;
            }
        }
        private DateTime mDepartureDate;
        private DateTime mArrivalDate;
        private DateTime mDepartureTime;
        public DateTime DepartureDate
        {
            get
            {
                // return the private data 
                return mDepartureDate;
            }
            set
            {
                //set he value of the private data memebr 
                mDepartureDate = value;
            }
        }
   
        public DateTime ArrivalDate

        {
            get
            {
                // return the private data 
                return mArrivalDate;
            }
            set
            {
                //set he value of the private data memebr 
                mArrivalDate = value;
            }
        }
   
        public DateTime DepartureTime
        {
            get
            {
                // return the private data 
                return mDepartureTime;
            }
            set
            {
                //set he value of the private data memebr 
                mDepartureTime = value;
            }
        }

        internal void Add(clsFlights aFlight)
        {
            throw new NotImplementedException();
        }

        private DateTime mArrivalTime;
        public DateTime ArrivalTime
        {
            get
            {
                // return the private data 
                return mArrivalTime;
            }
            set
            {
                //set he value of the private data memebr 
                mArrivalTime = value;
            }
        }
        private DateTime mDuration;
        public DateTime Duration
        {
            get
            {
                // return the private data 
                return mDuration; ;
            }
            set
            {
                //set he value of the private data memebr 
                mDuration = value;
            }
        }
        private string mCost;
        public string Cost
        {
            get
            {
                // return the private data 
                return mCost;
            }
            set
            {
                //set he value of the private data memebr 
                mCost = value;
            }
        }
        public string Flight { get; set; }




        public string Valid(string someFlight)
        {
            // string variable to store the error message 
            string Error = "";

            //if the name of the customer is more than 5 character 
            if (someFlight.Length > 50)
            {
                //return error messgae 
                return "Flight Name Cannot Be more than 50 characters  ";

            }
            if (someFlight.Length == 0)
            {
                //return error messgae 
                return "Flight Name Cannot Be Blank! ";

            }
            return Error;
        }

        public bool Find(int AddressNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@FlightNo", FlightNo);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByFlightNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mFlightNo = Convert.ToInt32(DB.DataTable.Rows[0]["FlightNo"]);
                mDepartureAirport = Convert.ToString(DB.DataTable.Rows[0]["DeparturAirport"]);
                mArrivalAirport = Convert.ToString(DB.DataTable.Rows[0]["ArrivalAirport"]);
                mDepartureTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DepartureTime"]);
                mArrivalTime = Convert.ToDateTime(DB.DataTable.Rows[0]["ArrivalTime"]);
                mDuration = Convert.ToDateTime(DB.DataTable.Rows[0]["Duration"]);
                mDepartureDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DepartureDate"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }


        public static implicit operator clsFlights(List<clsFlights> v)
        {
            throw new NotImplementedException();
        }
    }
}