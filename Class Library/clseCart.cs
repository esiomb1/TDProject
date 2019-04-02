using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class clseCart
{
    List<clseCartItem> mBookings = new List<clseCartItem>();

    public clseCart()
    {
        //  mOrderDate = DateTime.Now.Date;
    }
    private int mBookingNo;
    public int BookingNo
    {
        get
        {
            return mBookingNo;
        }
        set
        {
            mBookingNo = value;
        }
    }
    private string mFirstName;
    public string FirstName
    {
        get
        {
            return mFirstName;
        }
        set
        {
            mFirstName = value;
        }
    }
    private string mLastName;
    public string LastName
    {
        get
        {
            return mLastName;
        }
        set
        {
            mLastName = value;
        }
    }
    private string mAddress;
    public string Address
    {
        get
        {
            return mAddress;
        }
        set
        {
            mAddress = value;
        }
    }
    private string mPostCode;
    public string PostCode
    {
        get
        {
            return mPostCode;
        }
        set
        {
            mPostCode = value;
        }
    }
    private string mCardNo;
    public string CardNo
    {
        get
        {
            return mCardNo;
        }
        set
        {
            mCardNo = value;
        }
    }
    public DateTime mExpiryDate;
    public DateTime ExpiryDate
    {
        get
        {
            return mExpiryDate;
        }
        set
        {
            mExpiryDate = value;
        }
    }
    private String mCVSNo;
    public string CVSNo
    {
        get
        {
            return mCVSNo;
        }
        set
        {
            mCVSNo = value;
        }
    }



    // private DateTime mOrderDate;


    public void Checkout()
    {
        ///at this point all the data has been captured by the presentation layer
        ///this is the stage where all of the data is passed to the data layer via the two stored procedures like so
        ///

        //first we add the order to the database using data from the cart's private data member s
        //connect to the database
        clsDataConnection DB = new clsDataConnection();
        //pass the data as parameters to the data layer
        DB.AddParameter("@BookingNo", mBookingNo);
        DB.AddParameter("@FirstName", mFirstName);
        DB.AddParameter("@LastName", mLastName);
        DB.AddParameter("@Address", mAddress);
        DB.AddParameter("@PostCode", mPostCode);
        DB.AddParameter("@CardNo", mCardNo);
        DB.AddParameter("@Expiry", mExpiryDate);
        DB.AddParameter("@CVSNo", mCVSNo);

        //execute the stored procedure capturing the primary key of the new record in the variable OrderNo
        Int32 NewOrderNo;
        NewOrderNo = DB.Execute("sproc_tblOrder_Insert");

        //now we need to loop through all the product adding them to the order line table
        Int32 Index = 0;
        Int32 Count = mBookings.Count;
        while (Index < Count)
        {
            //reset the connection to the database
            DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", NewOrderNo);
            DB.AddParameter("@BookingNo", mBookings[Index].BookingNo);
            DB.AddParameter("@Quantity", mBookings[Index].QTY);
            Int32 OrderNo = DB.Execute("sproc_tblOrderLine_Insert");
            Index++; ;
        }
        //now look in the tables and the order should be present
        //we could also do other things here such as adjust stock levels
    }

























}