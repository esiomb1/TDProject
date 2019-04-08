using System;

namespace Class_Library
{
    public class clsShowing
    {
        public int ShowingId { get; set; }
        public string ShowingName { get; set; }

        public string Valid(string someShowing)
        {
            //if the nam of the showing is not blank
            if (someShowing != "")
            {
                //reurn a blank string
                return "";
            }
            else
            {
                //otherwise return an error message
                return "The showing name may not be blank!";
            }
        }
    }
    }
