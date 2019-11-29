using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmLibrary;
using System.IO;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Give me the ini file in which you want to work: ");
            string file = Console.ReadLine();
            if (File.Exists(file))
            {
                FileHandling fh = new FileHandling();
                filmHandle filmh = new filmHandle();
                List<Film> filmList = filmh.readFilmList(fh.ReadFromFile(file));
                while (true)
                {

                    try
                    {
                        displayMenu(mainMenu());
                        Console.Write("Enter a number to enter a menu: ");

                        int menuNumber = Convert.ToInt32(Console.ReadLine());

                        if (menuNumber == 1)
                        {
                            Console.WriteLine(filmh.displayFilms(filmList));
                        }
                        else if (menuNumber == 2)
                        {
                            Console.Write("Give me the film title: ");
                            Console.WriteLine(filmh.FilmsByTitle(filmList, Console.ReadLine()));
                        }
                        else if (menuNumber == 3)
                        {
                            Console.Write("Give me the film title: ");
                            string title = "[" + Console.ReadLine() + "]";
                            string[] keywords = { "director", "release_year", "stars", "budget" };
                            List<string> results = new List<string>();
                            foreach (string element in keywords)
                            {
                                Console.Write($"Give me the {element}: ");
                                results.Add(Console.ReadLine());
                            }

                            filmh.addFilm(filmList, title, results[0], Convert.ToInt32(results[1]), results[2], Convert.ToInt32(results[3]));
                        }
                        else if (menuNumber == 4)
                        {
                            Console.Write("Give me the title: ");
                            string title = "[" + Console.ReadLine() + "]";

                            filmh.deleteFilmByTitle(filmList, title);
                        }
                        else if (menuNumber == 5)
                        {
                            fh.writeToFile(file, filmList);

                        }
                        else if (menuNumber == 6)
                            Environment.Exit(0);

                        else if (menuNumber > 6)
                            Console.WriteLine("there is no such option");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }



        }
        static string[] mainMenu()
        {
            string[] mainMenu = { "Display films", "Films by Title", "Add Films", "Delete Films","Write To The File", "Exit" };
            return mainMenu;
        }
        static void displayMenu(string[] mainMenu)
        {
            int number = 1;
            foreach(string titles in mainMenu)
            {
                Console.WriteLine("({0}) {1}", Convert.ToString(number), titles);
                number++;
            }
        }

       
    }
}
