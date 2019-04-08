using System;

namespace Class_Library
{
    public class clsOrder
    {
        //private data member for the orderNo property 
        private int mOrderNo;
        private int mCustomerID;
        private int mPhoneID;
        private int mPrice;
        private DateTime mOrderDate;



        public string Order { get; set; }
        public int OrderNo
        {
            get
            {
                //return the private data 
                return mOrderNo;
            }
            set
            {
                //set the value of the private data member 
                mOrderNo = value;
            }
        }


        public bool Active { get; set; }
        public DateTime OrderDate
        {
            get
            {
                //return the private data 
                return mOrderDate;
            }
            set
            {
                //set the value of the private data member 
                mOrderDate = value;
            }
        }


        public int Price
        {
            get
            {
                //return the private data 
                return mPrice;
            }
            set
            {
                //set the value of the private data member 
                mPrice = value;
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

        public string Valid(string someOrder)
        {
            //if the name of the order is not blank 
            if (someOrder != "")
            {
                //return a blank string 
                return "";
            }
            else
            {
                //otherwise return an error message 
                return "The order name may not be blank";
            }
        }


        public bool Find(int OrderNo)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for 
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mPhoneID = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneID"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);

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