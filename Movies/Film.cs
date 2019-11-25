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
        public List<string> Director { get; set; }
        public int ReleaseYear { get; set; }
        public List<string> Stars { get; set; }
        public int Budget { get; set; }

        public Film(string title,List<string> director,int releaseYear,List<string> stars,int budget)
        {
            this.Title = title;
            this.Director = director;
            this.ReleaseYear = releaseYear;
            this.Stars = stars;
            this.Budget = budget;
        }

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();
            sr.Append($"{this.Title} , director {this.Director}, in {this.ReleaseYear}, the film star(s) {this.Stars} the budget was {this.Budget}");
            return sr.ToString();
        }
    }
}
