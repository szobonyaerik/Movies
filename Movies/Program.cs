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
            
            var xy = FileHandling.ReadFromFile("../../Films.ini");
            foreach (var element in xy.Values)
                foreach (var el in element.Keys)
                    Console.WriteLine(el);










        }

       
    }
}
