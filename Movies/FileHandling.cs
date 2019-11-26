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
        public static Dictionary<string, Dictionary<string, List<string>>> ReadFromFile(string FileName)
        {
            List<string> t = new List<string>();
            string keyValue = "";
            Dictionary<string, Dictionary<string, List<string>>> allFilm = new Dictionary<string, Dictionary<string, List<string>>>();
            Dictionary<string,List<string>> oneField = new Dictionary<string, List<string>>();
            var file = File.ReadAllLines(FileName);
            
            for( int i = 0; i < file.Count();i++)
            {
                if (file[i].Contains('='))
                {
                    var result = file[i].Split('=');
                    foreach (var element in result)
                    {
                        t.Add(element);
                        keyValue = t[0];
                        t.Remove(t[0]);

                    }
                    oneField.Add(keyValue, t);

                }
                if (i != 0 && i % 5 == 0)
                {
                    allFilm.Add(file[i], oneField);
                    oneField = new Dictionary<string, List<string>>();
                }
                    




                

            }
            return allFilm;

            

        }

 

    }
}
