using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{

    namespace Class_Library
    {
        public class clsCustomer
        {

            //hello 


            public string Customer { get; set; }
            public int CustomerNo { get; set; }
            public string FirstName { get; set; }
            public string EmailAddress { get; set; }
            public string Mobile { get; set; }
            public string LastName { get; set; }
            public string PostCode { get; set; }
            public string Address { get; set; }




            public string Valid(string someCustomer)
            {
                // string variable to store the error message 
                string Error = "";

                //if the name of the customer is more than 5 character 
                if (someCustomer.Length > 50)
                {
                    //return error messgae 
                    return "Customer Name Cannot Be more than 50 characters  ";

                }
                if (someCustomer.Length == 0)
                {
                    //return error messgae 
                    return "Customer Name Cannot Be Blank! ";

                }
                return Error;
            }
        }
    }

}