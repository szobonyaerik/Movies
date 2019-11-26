using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
    

{
    class filmHandle
    {
        public static string filmsByTitle()
        {
            StringBuilder sr = new StringBuilder();
            var filmDictionaryes = FileHandling.ReadFromFile("../../Films.ini");
            Console.Write("Give me the film Title: ");
            string title = Console.ReadLine();
            if(filmDictionaryes.ContainsKey("[" + title + "]"))
            {
                var thefilm = filmDictionaryes["[" + title + "]"];
                string result = $"Title = {title}\nDirector = {thefilm["director"]},\nRelease year = {thefilm["release_year"]}\nStars = {thefilm["stars"]}\nBudget = {thefilm["budget"]}\n";

                return result;
            }
            else
            {
                return "This film is not in the file.";
            }

            


        }
        public static void displayFilms()
        {
            var filmDictionaryes = FileHandling.ReadFromFile("../../Films.ini");

            foreach (var title in filmDictionaryes.Keys)
            {
                var thefilm = filmDictionaryes[title];
                string result = $"Title = {title}\nDirector = {thefilm["director"]}" +
                    $",\nRelease year = {thefilm["release_year"]}\nStars = {thefilm["stars"]}\nBudget = {thefilm["budget"]}\n";

                Console.WriteLine(result);
            }
            
        }
    }
}
