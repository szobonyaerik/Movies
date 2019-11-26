using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
    

{
    class filmHandle
    {
        public static string filmByTitle()
        {
            List<Film> filmList = new List<Film>();
            var filmDictionaryes = FileHandling.ReadFromFile("../../Films.ini");
            Console.WriteLine("Kurva anyád");
            return "faszocskák";


        }
    }
}
