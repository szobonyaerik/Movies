using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
    

{
    enum filmData
    {
        DIRECTOR,
        RELASEYEAR,
        STARS,
        BUDGET,

        
    }
    class filmHandle
    {
        public static List<Film> writeOutAllFilms()
        {
            List<Film> filmList = new List<Film>();
            var filmDictionaryes = FileHandling.ReadFromFile("../../Films.ini");

            return filmList;
        }

    }
}
