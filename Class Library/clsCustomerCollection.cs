using System;
using System.Collections.Generic;
using System.Linq;


namespace Class_Library
{
    public class clsCustomerCollection

    {
        private List<clsCustomer> mAllCustomers = new List<clsCustomer>();

        public clsCustomerCollection()// public contructor to the class

        {
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to geth the list of data 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of record 
            Int32 RecordCount = DB.Count;
            //set up the indx for the loop 
            Int32 Index = 0;
            //while there ar records to proces 
            while (Index < RecordCount)
            {
                // create an istance of the customer class 
                clsCustomer ACustomer = new clsCustomer();
                // get the customers name 
                ACustomer.Customer = DB.DataTable.Rows[Index]["Customer"].ToString();
                //get the primar key 
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                //add the customer to the private data member 
                mAllCustomers.Add(ACustomer);
                //incriment the index
                Index++;
            }


        }


        public int Count
        {
            get
            {
                // return the count property of the private list
                return mAllCustomers.Count;

            }
            set
            {
                // assign the incoming value to the private data member 

            }
        }
        public List<clsCustomer> AllCustomers
        {// getter send the data to requesting code
            get
            {
                // return the count property of the private list
                return mAllCustomers;

            }// setter accepts data from other object
            set
            {
                // assign the incoming value to the private data member 
                mAllCustomers = value;
            }
        }
    }
}