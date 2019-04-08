using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Class_Library
{
    public class clsCinema
    {
        private Int32 mCinemaId;
        //public property for cinemaid
        public Int32 CinemaId
        {
            get
            {
                return mCinemaId;
            }
            set
            {
                mCinemaId = value;
            }
        }

        private string mCinema;
        //public property for Cinema
        public string Cinema
        {
            get
            {
                return mCinema;
            }
            set
            {
                mCinema = value;
            }
        }
        //data member for data connection
        //private clsCinemaCollection dBConnection = new clsCinemaCollection();

        public string Valid(string someCinema)
        {//string variable to store the error message

            string Error = "";

            //if the name of the country is not blank

            if (someCinema.Length > 50)
            {

                //return an error message

                Error = "The Cinema name cannot have more than 50 characters";

            }
            if (someCinema.Length == 0)
            {

                // return an error message

                Error = "The Cinema name may not be blank!";


            }
            return Error;
        }
    }
}
    

    


