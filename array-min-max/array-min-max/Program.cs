using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            string EnteredSize;
            string EnteredItem;
            int size = 0;
            int[] array;
            int item = 0;
            Console.WriteLine(" please enter some adequate size of array");
            EnteredSize = Console.ReadLine();
            size = Int32.Parse(EnteredSize);
            array = new int[size];
            Console.WriteLine();
            Console.WriteLine(" now you should fill the array with the digits");
            Console.WriteLine();
            for (item = 0; item < size; item++)
            {
                EnteredItem = Console.ReadLine();
                array[item] = Convert.ToInt32(EnteredItem);
            }
            //foreach (int value in array)
            //{
            //    Console.WriteLine(value);
            //}
            Console.WriteLine(); 
            Console.WriteLine(" looks like min and max digits were:");            
            Console.WriteLine();
            Console.WriteLine("Min: " + Min(array));            
            Console.WriteLine("Max: " + Max(array));
            Console.WriteLine(); 
            Console.WriteLine(" now i should get a cookie");
            Console.ReadKey();
        }
        //find min
        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
                if (min > array[i])
                    min = array[i];
            return min;
        }
        //find max
        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
                if (max < array[i])
                    max = array[i];
            return max;
        }
    }
}
