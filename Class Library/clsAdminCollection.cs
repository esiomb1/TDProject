using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Class_Library
{
    class clsAdminCollection
    {
        //this class contains code allowing us to change the admin
        //create a null instance of the class clsDataConnection
        clsDataConnection dBConnection;
        //private data member for the current address
        clsAdmin mThisAdmin = new clsAdmin();

        public clsAdmin ThisAdmin
        {
            get
            {
                return mThisAdmin;
            }
            set
            {
                mThisAdmin = value;
            }
        }
        public Int32 Add()
        {
            //this function adds a new record to the database returning the primary key value of the new record

            //var to store the primary key value of the new record
            Int32 PrimaryKey;
            //create a connection to the database
            clsDataConnection NewAdmin = new clsDataConnection();
            //add the admin number parameter
            NewAdmin.AddParameter("@AdminNo", mThisAdmin.AdminNo);
            //add the admin email
            NewAdmin.AddParameter("@AdminEmail", mThisAdmin.AdminNo);
            //add the first name
            NewAdmin.AddParameter("@FirstName", mThisAdmin.FirstName);
            //add the last name parameter
            NewAdmin.AddParameter("@LastName", mThisAdmin.LastName);
            //add the blog parameter
            NewAdmin.AddParameter("@Blog", mThisAdmin.Blog);
            //add the active parameter
            NewAdmin.AddParameter("@Active", mThisAdmin.Active);

            //execute the query to add the record - it will return the primary key value of the new record
            PrimaryKey = NewAdmin.Execute("sproc_tblAdmin_Insert");
            //return the primary key value of the new record
            return PrimaryKey;
        }
        public void Update()
        {
            //this function updates an existing record specified by the class level variable addressNo
            //it returns no value

            //create a connection to the database
            clsDataConnection NewAdmin = new clsDataConnection();
            //add the admin number parameter
            NewAdmin.AddParameter("@AdminNo", mThisAdmin.AdminNo);
            //add the admin email
            NewAdmin.AddParameter("@AdminEmail", mThisAdmin.AdminNo);
            //add the first name
            NewAdmin.AddParameter("@FirstName", mThisAdmin.FirstName);
            //add the last name parameter
            NewAdmin.AddParameter("@LastName", mThisAdmin.LastName);
            //add the blog parameter
            NewAdmin.AddParameter("@Blog", mThisAdmin.Blog);
            //add the active parameter
            NewAdmin.AddParameter("@Active", mThisAdmin.Active);
            //execute the query
            NewAdmin.Execute("sproc_tblAdmin_Update");
        }
        ///this function deletes a record in the database based on the value of the addressNo var
        public void Delete()
        ///it is a void function and returns no value
        {
            //initialise the DBConnection
            dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@AdminNo", mThisAdmin.AdminNo);
            //execute the stored procedure to delete the address
            dBConnection.Execute("sproc_tblAdmin_Delete");
        }
        ///this function defines the public property Count
        public Int32 Count
        ///it returns the count of records currently in QueryResults
        {
            get
            {
                //return the count of records
                return dBConnection.Count;
            }
        }
        public List<clsAdmin> AdminList
        {
            get
            {
                List<clsAdmin> mAdminList = new List<clsAdmin>();
                Int32 Index = 0;
                while (Index < dBConnection.Count)
                {
                    clsAdmin NewAdmin = new clsAdmin();
                    //get the house no from the query results
                    NewAdmin.AdminNo = Convert.ToString(dBConnection.DataTable.Rows[Index]["AdminNo"]);
                    //get the street from the query results
                    NewAdmin.AdminEmail = Convert.ToString(dBConnection.DataTable.Rows[Index]["AdminEmail"]);
                    //get the post code from the query results
                    NewAdmin.FirstName = Convert.ToString(dBConnection.DataTable.Rows[Index]["FirstName"]);
                    //get the address no from the query results
                    NewAdmin.LastName = Convert.ToString(dBConnection.DataTable.Rows[Index]["LastName"]);
                    //get the address no from the query results
                    NewAdmin.Blog = Convert.ToString(dBConnection.DataTable.Rows[Index]["Blog"]);
                    //increment the index
                    Index++;
                    //add the address to the list
                    mAdminList.Add(NewAdmin);
                }
                //return the list of addresses
                return mAdminList;
            }

        }
    }
}
