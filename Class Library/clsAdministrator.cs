using System;

namespace Class_Library
{
    public class clsAdministrator
    {
        
        //private data member for the Admini ID property
        private int mAdministratorID;
        private int mCustomerID;
        private int mPhoneID;

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string CustomerDetails { get; set; }
        public int CustomerID
        {
            get
            {
                //return the private data 
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member                
                mCustomerID = value;
            }
        }
        public int PhoneID
        {
            get
            {
                //return the private data 
                return mPhoneID;
            }
            set
            {
                //set the value of the private data member 
                mPhoneID = value;
                
            }
        }

        public int AdministratorID
        {
            get
            {
                //return the private data 
                return mAdministratorID;
            }
            set
            {
                //set the value of the private data member 
                mAdministratorID = value;
              
            }
        }


        public bool Find(int AdministratorID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for 
            DB.AddParameter("@AdministratorID", AdministratorID);
            //execute the stored procedure 
            DB.Execute("sproc_tblAdministrator_FilterByAdministratorID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mAdministratorID = Convert.ToInt32(DB.DataTable.Rows[0]["AdministratorID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mPhoneID = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneID"]);

                return true;
            }

            //if no record was found 
            else
            {
                //return false indicating a problem 
                return false;





            }
        }  
    }
}