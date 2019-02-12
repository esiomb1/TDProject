using System;

namespace Class_Library
{
    public class clsFlights
    {

        //hello 


        public int FlightNo { get; set; }
        public string DepartureDestination { get; set; }
        public string ArrivalDestination { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
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
    }
}