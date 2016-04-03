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
            InsertionSorter ISsort = new InsertionSorter();
            ISsort.Sort(array);
            ISsort.Print(array);
            Console.WriteLine("end");

            Console.WriteLine("start");
            CreateArray(array);
            Console.WriteLine("Buble sorting");
            BubbleSorter BSsort = new BubbleSorter();
            BSsort.Sort(array);
            BSsort.Print(array);
            Console.WriteLine("end");

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
