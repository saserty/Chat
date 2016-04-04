using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            int size = 10;
            array = new int[size];

            Console.WriteLine("start");
            CreateArray(array);
            Console.WriteLine("Insertion sorting");
            InsertionSorter<int> ISsorter = new InsertionSorter<int>(array);
            ISsorter.Sort();
            ISsorter.Print();
            Console.WriteLine("end");
            
            Console.WriteLine("start");
            CreateArray(array);
            Console.WriteLine("Buble sorting");
            BubbleSorter<int> BSsorter = new BubbleSorter<int>(array);
            BSsorter.Sort();
            BSsorter.Print();
            Console.WriteLine("end");
            //Queue
            //Stack

            Console.ReadKey();
        }
        static void CreateArray(int[] array)
        {
            Random rand = new Random();
            for (int item = 0; item < array.Length; item++)
            {
                array[item] = rand.Next(100);
            }
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
