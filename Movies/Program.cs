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
            Console.WriteLine(FileHandling.ReadFromFile("../../Films.ini").Count());
            
        }

        static void x(ref int x)
        {
        }
    }
}
