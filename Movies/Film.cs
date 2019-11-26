using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Film
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string ReleaseYear { get; set; }
        public string Stars { get; set; }
        public int Budget { get; set; }

        public Film(string Title, string Director, string ReleaseYear, string Stars, int Budget)
        {
            this.Title = Title;
            this.Director = Director;
            this.ReleaseYear = ReleaseYear;
            this.Stars = Stars;
            this.Budget = Budget;
        }


    }
}
