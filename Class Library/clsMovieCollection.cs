using System.Collections.Generic;

namespace Class_Library
{
    public class clsMovieCollection
    {

        private List<clsMovies> mAllMovies = new List<clsMovies>();

        //public property for count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllMovies.Count;
            }
            set
            {

            }
        }
        //public property for allmovies
        public List<clsMovies> AllMovies
        {
            //getter sends data to requesting code
            get
            {
                //return private data member
                return mAllMovies;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllMovies = value;
            }
        }
    }
}
