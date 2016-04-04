using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            string digit1;
            string digit2;
            int digit1value = 0;
            int digit2value = 0;

            Console.WriteLine("this app will compare two integer only digits");
            Console.WriteLine("to find if second digit is divider of the first one");
            Console.WriteLine();
            Console.WriteLine("when you'll be ready, press any key to start");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("please enter digit 1: ");
            digit1 = Console.ReadLine();
            Console.Write("please enter digit 2: ");
            digit2 = Console.ReadLine();
            Console.WriteLine();
            digit1value = Int32.Parse(digit1);
            digit2value = Int32.Parse(digit2);
            Console.WriteLine("1: " + digit1value);
            Console.WriteLine("2: " + digit2value);
            Console.WriteLine();

            int rest = 0;
            rest = digit1value % digit2value;
            Console.Write("rest: "+rest);             
            Console.WriteLine();
            if (rest!=0)
            {
                Console.WriteLine("fail. second digit is not divider of the first one");
            }
            else
            {
                Console.WriteLine("success! second digit is divider of the first one");
            }
            Console.WriteLine();
            Console.WriteLine("now you'll be logged out");
            Console.ReadKey();
        }
    }
}
