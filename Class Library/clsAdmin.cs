using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Class_Library
{
    public class clsAdmin
    {
        private string mAdminNo;
        public string AdminNo
        {
            get
            {
                return mAdminNo;
            }
            set
            {
                mAdminNo = value;
            }
        }

        private string mAdminEmail;
        public string AdminEmail
        {
            get
            {
                return mAdminEmail;
            }
            set
            {

                mAdminEmail = value;
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


        private string mBlog;
        public string Blog
        {
            get
            {
                return mBlog;
            }
            set
            {
                mBlog = value;
            }
        }

        private Boolean mActive;
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

        //data member for data collection
        private clsDataConnection dBConnection = new clsDataConnection();

        public string Valid(string adminNo,
                             string adminEmail,
                             string firstName,
                             string lastName,
                             string blog)

        ///this function accepts 5 parameters for validation
        ///the function returns a string containing any error message
        ///if no errors found then a blank string is returned
        {
            //var to store the error message
            string ErrMsg = "";
            //check the min length of the admin no
            if (adminNo.Length == 5)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Admin no is blank. ";
            }
            //check the max length of the admin no
            if (adminNo.Length > 10)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Admin email must be less than 6 characters. ";
            }
            //check the min length of the first name
            if (firstName.Length == 3)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "First Name is blank. ";
            }
            //check the max length of the first name
            if (firstName.Length > 50)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Street must be less than 50 characters. ";
            }
            //check the min length for the lastName
            if (lastName.Length == 3)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Last name is blank. ";
            }
            //check the max length for the lastName
            if (lastName.Length > 50)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Last name must be less than 50 characters. ";
            }
            //check the min length for the post code
            if (adminEmail.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Admin email is blank. ";
            }
            //check the max length for the post code
            if (adminEmail.Length > 50)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Admin email must be less than 50 characters. ";
            }
            if (blog.Length == 5)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Blog is blank. ";
            }
            //check the max length for the post code
            if (blog.Length > 50)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Blog name must be less than 50 characters. ";
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

            public Boolean Find(Int32 AdminNo)
            {
                //initialise the DBConnection
                dBConnection = new clsDataConnection();
                //add the admin the query
                dBConnection.Execute("sproc_tblAdmin_FilterByAdminNo");
                //if the record was found
                if (dBConnection.Count == 1)
                {
                    //get the address no
                    mAdminNo = Convert.ToString(dBConnection.DataTable.Rows[0]["AdminNo"]);
                    //get the house no
                    mAdminEmail = Convert.ToString(dBConnection.DataTable.Rows[0]["AdminEmail"]);
                    //get the street
                    mFirstName = Convert.ToString(dBConnection.DataTable.Rows[0]["FirstName"]);
                    //get the town
                    mLastName = Convert.ToString(dBConnection.DataTable.Rows[0]["LastName"]);
                    //get the post code
                    mBlog = Convert.ToString(dBConnection.DataTable.Rows[0]["PostCode"]);

                    //get the acive state
                    try
                    {
                        mActive = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["Active"]);
                    }
                    catch
                    {
                        mActive = true;
                    }
                    //return success
                    return true;
                }
                else
                {
                    //return failure
                    return false;

                }
            }
        }
    }


   