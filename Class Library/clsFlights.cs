using System;

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



        public string DepartureDestination { get; set; }
        public string ArrivalDestination { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Duration { get; set; }
        public string Cost { get; set; }
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

        public bool Find(int flightNo)
        {
            // et the private data member to the test data value 
            mFlightNo = 21;
            // alway retrurn true 
            return true;
        }
      



    }
}