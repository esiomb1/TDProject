using System;

namespace Class_Library
{
    public class clsMovies
    {
        public string Movie { get; set; }
        public int MovieId { get; set; }
        public int DateReleased { get; set; }
        public string Director { get; set; }
        public string Category { get; set; }
        public string RunTime { get; set; }

        public string Valid(string someMovie)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the country is not blank
            if (someMovie.Length > 50)
            {
                //return an error message
                Error = "The Movie name cannot have more than 50 characters";
            }
            if (someMovie.Length == 0)
            {
                // return an error message
               Error = "The Movie name may not be blank!";
            }
            return Error;

            }
          
        }
       
    }
