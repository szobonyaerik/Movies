using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Movies
{
    class FileHandling
    {
        public static List<List<string>> ReadFromFile(string FileName)
        {   
            List<string> oneFilm = new List<string>();
            List<List<string>> allFilm = new List<List<string>>();
            var file = File.ReadAllLines(FileName);
            
            for( int i = 0; i < file.Count();i++)
            {
                oneFilm.Add(file[i]);
                if (i != 0 && i % 5 == 0)
                {
                    allFilm.Add(oneFilm);
                    oneFilm = new List<string>();
                }

            }
            return allFilm;

            

        }

 

    }
}
