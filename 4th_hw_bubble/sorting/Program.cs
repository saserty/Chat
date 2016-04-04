﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            int size = 10;
            array = new int[size];
            Random rand = new Random();
            Console.WriteLine("start");
            for (int item = 0; item < size; item++) //fill array
            {
                array[item] = rand.Next(100);
            }
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("sorting");
            Swap(array);
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("end");
            Console.ReadKey();
        }
        static void Swap(int[] array)
        {
            int temp = 0;
            int action1 = 0;
            int action2 = 0;
            do
            {
                action1 = 0;
                action2 = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        action1 = 1;
                    }
                    else
                    {
                        i = i;
                        action2 = 1;
                    }

                }
            }
            while (action1 == 1 && action2 == 1);
        }
    }
}
