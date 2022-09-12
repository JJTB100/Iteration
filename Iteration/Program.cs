using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Repeat 10000000000000000000000000000000000000 times
            for (int i = 1; i < 1000000000; i=i*2)
            {
                Console.WriteLine(i);
            }


            // Repeat until the use says "Quit"
            bool going = true;   
            while(going == true)
            {
                Console.WriteLine("Still Going?");

                going = Console.ReadLine().ToUpper() == "YES";
            }
            Console.ReadLine();
        }
    }
}
