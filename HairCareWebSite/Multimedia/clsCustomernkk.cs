using System;

namespace Class_Library
{
    public class clsCustomernkk
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }

        public string Valid(string someCustomer)
        {
            //if the name of the customer is not blank
            if (someCustomer != "")
            {
                //return a blank string
                return "";
            }
            else
            {
                //otherwise return an error message
                return "The Customer name may not be blank!";
            }
        }
    }
}