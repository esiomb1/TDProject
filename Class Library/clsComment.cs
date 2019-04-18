using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsComment
    {
        //private data member for the user
        private string mUser;
        //private data member for comment
        private string mComment;

        //public property for user
        public string User
        {
            get
            {
                //return private data
                return mUser;
            }
            set
            {
                //set the private data
                mUser = value;
            }

        }

        //public property for Comment
        public string Comment
        {
            get
            {
                return mComment;
            }
            //set the private data
            set
            {
                mComment = value;
            }
        }
    }
}


