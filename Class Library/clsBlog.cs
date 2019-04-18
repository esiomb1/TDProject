using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class clsBlog
{
    private string mBlogDescription;

    public string BlogDescription
    {
        get
        {
            return mBlogDescription;
        }
        set
        {
            mBlogDescription = value;
        }
    }

    private Int32 mBlogNo;

    public Int32 BlogNo
    {
        get
        {
            return mBlogNo;
        }
        set
        {
            mBlogNo = value;
        }
    }

    private DateTime mDateReleased;
    public DateTime DateReleased
    {
        get
        {
            return mDateReleased;
        }
        set
        {
            mDateReleased = value;
        }
    }

    private string mEmail;
    public string Email
    {
        get
        {
            return mEmail;
        }
        set
        {
            mEmail = value;
        }
    }
    private Boolean mActive;
    //Active public property
    public Boolean Active
    {
        get
        {
            return mActive;
        }
        set
        {
            mActive = value;
        }
    }

    public int Count { get; set; }

    private clsDataConnection dBConnection = new clsDataConnection();

    //function for the public validation method needed
    public string Valid(string blogNo,
                        string blogDescription,
                        string email,
                        string dateReleased)

    //this function accepts 4 parameters for validation
    ///the function returns a string containing any error message
    ///if no errors found then a blank string is returned
    {
        //var to stpre the error message
        string ErrMsg = "";
        //check the min length
        if (blogNo.Length == 0)
        {
            //set the error msg
            ErrMsg = ErrMsg + "Blog number is blank. ";
        }
        //check the max length of the blog number
        if (blogNo.Length > 20)
        {
            ErrMsg = ErrMsg + "Blog number must be less than 20 characters. ";
        }
        //check the min length for blog decription 

        if (blogDescription.Length == 0)
        {
            //set the error msg
            ErrMsg = ErrMsg + "Blog description is blank. ";
        }
        //check the max length of the blog number
        if (blogDescription.Length > 100)
        {
            ErrMsg = ErrMsg + "Blog description must be less than 100 characters. ";
        }
        //check the min length for blog decription 

        if (email.Length == 0)
        {
            //set the error msg
            ErrMsg = ErrMsg + "email feild is blank. ";
        }
        //check the max length of the blog number
        if (email.Length > 50)
        {
            ErrMsg = ErrMsg + "email must be less than 50 characters. ";
        }
        //check the min length for blog decription 

        try//try the operation
        {
            //var to store the date
            DateTime Temp;
            //assign the date to the temporary var
            Temp = Convert.ToDateTime(dateReleased);
        }
        catch//if it failed report an error
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Date released is not valid. ";
        }
        //if there were no errors
        if (ErrMsg == "")
        {
            //return a blank string
            return "";
        }
        else//otherwise
        {
            //return the errors string value
            return "There were the following errors : " + ErrMsg;
        }
    }

    //function for the find public method
    public Boolean Find(Int32 BlogNo)
    {
        //initialise the DBConnection
        dBConnection = new clsDataConnection();
        //add the address no parameter
        dBConnection.AddParameter("@BlogNo", BlogNo);
        //execute the query
        dBConnection.Execute("sproc_tblBlog_FilterByBlogNo");
        //if the record was found
        if (dBConnection.Count == 1)
        {
            //get the blogNo
            mBlogNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["BlogNo"]);
            //get the house no
            mBlogDescription = Convert.ToString(dBConnection.DataTable.Rows[0]["BlogDescription"]);
            //get the street
            mEmail = Convert.ToString(dBConnection.DataTable.Rows[0]["Email"]);
            //get the town
            mDateReleased = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DateReleased"]);
            //get the acive state
            try
            {
                mActive = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["Active"]);
            }
            catch
            {
                mActive = true;
            }
            return true;
        }
        else
        {
            return false;
        }
    }

    public string Valid(int blogNo, string blogDescription, string email, int v1, int v2, int v3)
    {
        throw new NotImplementedException();
    }

    public string Valid(string blogNo, string blogDescription, string email, int v1, int v2, int v3)
    {
        throw new NotImplementedException();
    }
}


