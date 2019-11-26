using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {

            
            displayMenu(mainMenu());
            Console.Write("Enter a number to enter a menu: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                filmHandle.filmByTitle();
            }
            else if(x == 2)
            {
                filmHandle.filmByTitle();
            }
            else if(x == 3)
            {
                filmHandle.filmByTitle();
            }
            else if(x == 4)
            {
                filmHandle.filmByTitle();
            }
            else if(x == 5)
            {
                System.Environment.Exit(0);

            }


            Console.ReadLine();










        }
        static string[] mainMenu()
        {
            string[] mainMenu = { "Display films", "Films by Title", "Add Films", "Delete Films", "Exit" };
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
