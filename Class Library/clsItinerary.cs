using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
 public   class clsItinerary
    { 

        //hello 


        public string Itinerary { get; set; }
        public int CustomerNo { get; set; }
        public int ItineraryNo { get; set; }
        public int BookingNo { get; set; }
        public int DepartureFlightNo { get; set; }
        public int ArrivalFlightNo { get; set; }





        public string Valid(string someItinerary)
        {
            // string variable to store the error message 
            string Error = "";

            //if the name of the customer is more than 5 character 
            if (someItinerary.Length > 50)
            {
                //return error messgae 
                return "Itinerary Name Cannot Be more than 50 characters  ";

            }
            if (someItinerary.Length == 0)
            {
                //return error messgae 
                return "Itinerary Name Cannot Be Blank! ";

            }
            return Error;
        }
    }
}
