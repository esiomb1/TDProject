using System;
namespace Class_Library
{
    public class clsBookings
    {

        //hello 

        public int BookingNo { get; set; }
        public int CustomerNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string CardNo { get; set; }
        public string ExpiryDate { get; set; }
        public string CVSNo{ get; set; }
        public string Booking { get; set; }

        public string Valid(string someBooking)
        {
            // string variable to store the error message 
            string Error = "";

            //if the name of the customer is more than 5 character 
            if (someBooking.Length > 50)
            {
                //return error messgae 
                return "Customer Name Cannot Be more than 50 characters  ";

            }
            if (someBooking.Length == 0)
            {
                //return error messgae 
                return "Customer Name Cannot Be Blank! ";

            }
            return Error;
        }
    }
}