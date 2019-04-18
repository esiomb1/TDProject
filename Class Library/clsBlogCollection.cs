using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsBlogCollection
    {

        ///this class contains code allowing us to manipulate the blog

        //private data members
        //create a null instance of the class clsDataConnection with class level scope
        clsDataConnection dBConnection;
        //private data member for the current address
        clsBlog mThisBlog = new clsBlog();

        public clsBlog ThisAddress
        {
            get
            {
                return mThisBlog;
            }
            set
            {
                mThisBlog = value;
            }
        }

        //function for the public add method
        public Int32 Add()
        {
            //this function adds new records to the database returning the primary key value of the new record
            //var to store the primary key vaue of the new record
            Int32 PrimaryKey;
            //create a connection to the database
            clsDataConnection NewBlog = new clsDataConnection();
            //add the blog number parameter
            NewBlog.AddParameter("@BlogNo", mThisBlog.BlogNo);
            //add the blog description parameter
            NewBlog.AddParameter("@BlogDescription", mThisBlog.BlogDescription);
            //add the email parameter
            NewBlog.AddParameter("@Email", mThisBlog.Email);
            //add the date released parameter
            NewBlog.AddParameter("@DateReleased", mThisBlog.DateReleased);
            //add the active parameter
            NewBlog.AddParameter("@Active", mThisBlog.Active);
            //execute the query to add the record - it will return the primary key value of the new record
            PrimaryKey = NewBlog.Execute("sproc_tblBlog_Insert");
            //return the primary key value of the new record
            return PrimaryKey;
        }
        public void Update()
        {
            //this function updates an exisiting record that is specified by the class level variable blogNo
            //it returns no value

            //create a connection to the database
            clsDataConnection NewBlog = new clsDataConnection();
            //add the blog no parameter 
            NewBlog.AddParameter("@BlogNo", mThisBlog.BlogNo);
            //add the blog description parameter
            NewBlog.AddParameter("@BlogDescription", mThisBlog.BlogDescription);
            //add the email parameter
            NewBlog.AddParameter("@Email", mThisBlog.Email);
            //add the date released parameter
            NewBlog.AddParameter("@DateReleased", mThisBlog.DateReleased);
            //add the active parameter
            NewBlog.AddParameter("@Active", mThisBlog.Active);
            //execute the query
            NewBlog.Execute("sproc_tblBlog_Update");
        }
        public void Delete()
        {
            //initialise the DBConnection
            dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@BlogNo", mThisBlog.BlogNo);
            //execute the stored procedure to delete the blog
            dBConnection.Execute("sproc_tblBlog_Delete");
        }

        ///this function defines the FilterByBlogNo method
        public void FilterByBlogNo(string BlogNo)
        ///it accepts a single parameter PostCode and returns no value
        {
            //initialise the DBConnection
            dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@BlogNo", BlogNo);
            //execute the stored procedure to delete the address
            dBConnection.Execute("sproc_tblBlog_FilterByBlogNo");
        }

        ///this function defines the public property Count
        public int Count
        ///it returns the count of records currently in QueryResults
        {
            get
            {
                //return the count of records
                return mThisBlog.Count;
            }
            set
            {
                //assign the incoming value to the privae member
            }
        }

        ///this function exposes the DataTable via the public collection AllAddresses
        public List<clsBlog> BlogList
        {
            get
            {
                List<clsBlog> mBlogList = new List<clsBlog>();
                Int32 Index = 0;
                while (Index < dBConnection.Count)
                {
                    clsBlog NewBlog = new clsBlog();
                    //get the blog no from the query results
                    NewBlog.BlogNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["BlogNo"]);
                    //get the blog description from the query results
                    NewBlog.BlogDescription = Convert.ToString(dBConnection.DataTable.Rows[Index]["BlogDescription"]);
                    //get the email from the query results
                    NewBlog.Email = Convert.ToString(dBConnection.DataTable.Rows[Index]["Email"]);
                    //get the date released from the query results
                    NewBlog.DateReleased = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["DateReleased"]);
                    //increment the index
                    Index++;
                    //add the blog to the list
                    mBlogList.Add(NewBlog);
                }

                //return the list of blog numbers
                return mBlogList;
            }
        }
    }
}


