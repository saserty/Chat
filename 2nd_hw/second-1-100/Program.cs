using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            Console.WriteLine(" hello");
            Console.WriteLine(" this program will print the numbers from 1 to 100");
            Console.WriteLine(" but");
            Console.WriteLine(" for multiples of 3 you'll see “fizz” instead of the number");
            Console.WriteLine(" for multiples of 5 you'll see “buzz”");
            Console.WriteLine(" for numbers which are multiples of both 3 and 5 you'll see “fizzbuzz”");            
            Console.WriteLine(" press any key to start");
            Console.ReadKey();
            Console.WriteLine();
            do
            {
                if (number%3==0 && number%5==0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
                number++;
            }
            while (number < 101);
            Console.ReadKey();
        }
    }
}
