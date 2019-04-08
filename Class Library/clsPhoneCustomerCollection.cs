using System.Collections.Generic;
using System.Linq;
using System.Text;
using System; 

namespace Class_Library
{
    public class clsPhoneCustomerCollection
    {

        //private data member for the AllPhoneCustomers 
        private List<clsPhoneCustomer> mAllPhoneCustomers = new List<clsPhoneCustomer>();

       // private List<clsPhoneCustomer> mAllPhoneCustomers = new List<clsPhoneCustomer>();
        public List<clsPhoneCustomer> AllPhoneCustomers
        {
            // getter send the data to requesting code
            get
            {
                // return the count property of the private list
                return mAllPhoneCustomers;

            }
            // setter accepts data from other object
            set
            {
                // assign the incoming value to the private data member 
                mAllPhoneCustomers = value;
            }
        }

        public int Count
        {
            get
            {
                // return the count property of the private list
                return mAllPhoneCustomers.Count;

            }
            set
            {
                //assign the incoming value to the private data member 


            }
        }
        //public clsPhoneCustomer for the class 
       /* public clsPhoneCustomerCollection()
        {
            //create an instance of the PhoneCustomer class to store a Phone Customer 
            clsPhoneCustomer APhoneCustomer = new clsPhoneCustomer();
            //set the Phone Customer ID 
            APhoneCustomer.PhoneCustomer = "J123432";
            //add the customer id to the private list of customers 
            mAllPhoneCustomers.Add(APhoneCustomer);
            // re initialise the APhoneCustomer
            APhoneCustomer = new clsPhoneCustomer();
            //set the customer id
            APhoneCustomer.PhoneCustomer = "S3246454";
            //add the second custome id to the private list of customers 
            mAllPhoneCustomers.Add(APhoneCustomer);
            //the private lists now contains two customer id 
        }
        */

    }

    
    



}