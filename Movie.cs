using System;
using System.Collections.Generic;
using System.Text;

namespace begineer_guide
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle,string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;

        }
    }
}
