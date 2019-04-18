using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class ClsCommentsCollection
    {
        public void InsertComment(string user, string comment)
        {
            //use stored procedure
            clsDataConnection NewComment = new clsDataConnection();
            NewComment.AddParameter("@User", user);
            NewComment.AddParameter("@Comment", comment);

            NewComment.Execute("sproc_tblComment_insert");

        }
        public List<clsComment> mAllComments
        {
            get
            {
                return mAllComments;
            }
            set
            {
                //asign the incomign value to the private data member
                mAllComments = value;

            }

        }
    }
}
