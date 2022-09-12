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
            /* Repeat 10000000000000000000000000000000000000 times
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
            */

            // Repeats from 1 to 50
            for (ulong i = 2d; i < 18446744073709551615; i=i*i)
            {
                // Say if a number is odd or even
                string oddOrEven = (i % 2 == 0) ? "even" : "odd";


                Console.WriteLine($"{i} is {oddOrEven}");
                // Say if a number is divisible by 3

                string divisibleBy3 = (i % 3 == 0) ? "divisible by 3" : "not divisible by 3";
                Console.WriteLine($"{i} is {divisibleBy3}");


            }

            Console.ReadLine();

        }
    }
}
