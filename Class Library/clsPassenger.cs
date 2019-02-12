using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
  public class clsPassenger
 
    {

        //hello 


        public string Passenger { get; set; }
        public int PassengerNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Nationality { get; set; }
        public string PassportNo{ get; set; }




        public string Valid(string somePassenger)
        {
            // string variable to store the error message 
            string Error = "";

            //if the name of the customer is more than 5 character 
            if (somePassenger.Length > 50)
            {
                //return error messgae 
                return "Passenger Name Cannot Be more than 50 characters  ";

            }
            if (somePassenger.Length == 0)
            {
                //return error messgae 
                return "Customer Name Cannot Be Blank! ";

            }
            return Error;
        }
    }
}
