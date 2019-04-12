using System;

namespace Class_Library
{
    public class clsStock
    {
        private int mStockNo;
        private int mQuantity;
        private int mPhoneID;


        public int StockNo
        {
            get
            {
                //return the private data 
                return mStockNo;
            }
            set
            {
                //set the vlaue of the private data member 
                mStockNo = value;
            }
        }
        public int Quantity
        {
            get
            {
                //return the private data 
                return mQuantity;
            }
            set
            {
                //set the vlaue of the private data member 
                mQuantity = value;
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
                //set the vlaue of the private data member 
                mPhoneID = value;
            }
        }




        public bool Find(int StockNo)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for 
            DB.AddParameter("@StockNo", StockNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_FilterByStockNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["mStockNo"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["mQuantity"]);
                mPhoneID = Convert.ToInt32(DB.DataTable.Rows[0]["mPhoneID"]); ;

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