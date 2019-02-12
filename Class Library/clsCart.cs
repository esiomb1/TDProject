using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCart
/// </summary>
public class clsCart
{

    /// <summary>
    /// this class defines some tyical attributes of a shopping cart
    /// 
    /// clsCart
    /// ___________________________________________________________________________________
    /// Properties
    /// public DateTime DateAdded (note that the value of this is set in the constructor)
    /// public Int32 UserNo
    /// public string CardNo
    /// public List<clsCartItem> Products
    /// ___________________________________________________________________________________
    /// Methods
    /// public void Checkout()
    /// public void CalcTotalPrice()
    /// ___________________________________________________________________________________
    /// </summary>

    List<clsCartItem> mProducts = new List<clsCartItem>();
    public clsCart()
    {
        DateAdded = DateTime.Now.Date;
    }

    private DateTime mDateAdded;
    public DateTime DateAdded
    {
        get
        {
            return mDateAdded;
        }
        set
        {
            DateAdded = value;
        }
    }

    private Int32 mUserNo;
    public Int32 UserNo
    {
        get
        {
            return mUserNo;
        }
        set
        {
            mUserNo = value;
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

    public List<clsCartItem> Price
    {
        get
        {
            return price;
        }
     
    }
    public List<clsCartItem> Products
    {
        get
        {
            return mProducts;
        }
    }

    public void Checkout()
    {
        ///at this point all the data has been captured by the presentation layer
        ///this is the stage where all of the data is passed to the data layer via the two stored procedures like so
        ///

        //first we add the order to the database using data from the cart's private data member s
        //connect to the database
        clsDataConnection DB = new clsDataConnection();
        //pass the data as parameters to the data layer
        DB.AddParameter("@DateAdded", mDateAdded);
        DB.AddParameter("@CustomerNo", mUserNo);
        DB.AddParameter("@CardNo", mCardNo);
        //execute the stored procedure capturing the primary key of the new record in the variable OrderNo
        Int32 NewOrderNo;
        NewOrderNo = DB.Execute("sproc_tblOrder_Insert");

        //now we need to loop through all the product adding them to the order line table
        Int32 Index = 0;
        Int32 Count = mProducts.Count;
        while (Index < Count)
        {
            //reset the connection to the database
            DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", NewOrderNo);
            DB.AddParameter("@ProductNo", mProducts[Index].ProductId);
            DB.AddParameter("@Quantity", mProducts[Index].QTY);
            Int32 OrderNo = DB.Execute("sproc_tblOrderLine_Insert");
            Index++;

        }
        //now look in the tables and the order should be present
        //we could also do other things here such as adjust stock levels
    }


    private decimal CalculateTotalPrice()
    {
        var totalPrice = 0m;
        foreach (var product in Products)
        {
            totalPrice += Products.Price;
        }
        return totalPrice;
    }

}