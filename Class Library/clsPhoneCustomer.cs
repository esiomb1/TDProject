using System;

namespace Class_Library
{
    public class clsPhoneCustomer
    {
        public string PhoneCustomer { get; set; }
        public int PhoneCustomerNo { get; set; }

        public string Valid(string someAPhoneCustomer)
        {
            //if the name of the PhoneCustomer is not blank 
            if (someAPhoneCustomer != "")
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