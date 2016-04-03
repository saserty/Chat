using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    class BubbleSorter
    {
        public void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        public void Sort(int[] array)
        {
           int action1 = 0;
           do
            {
                action1 = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        action1 = 1;
                    }
                    else
                    {
                        i = i;
                    }

                }
            }
            while (action1 == 1);
        }
        public void Print(int[] array)
        {
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
