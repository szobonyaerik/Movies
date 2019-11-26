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
            Console.Write("Give me the film Title: ");
            string title = Console.ReadLine();
            var thefilm = filmDictionaryes["[" + title + "]"];
            string result = $"Title = {title}\nDirector = {thefilm["director"]},\nRelease year = {thefilm["release_year"]}\nStars = {thefilm["stars"]}\nBudget = {thefilm["budget"]}\n";

            return result;
            

            


        }
    }
}
