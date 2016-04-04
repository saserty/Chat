using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    public class InsertionSorter
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
            int action2 = 0;
            do
            {
                action1 = 0;
                action2 = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (i == 0)
                    {
                        i = 1;
                    }
                    else if ((array[i] < array[i - 1]) && i > 0)
                    {
                        Swap(ref array[i], ref array[i - 1]);
                        action1 = 1;
                        i = i - 2;
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
        public void Print(int[] array)
        {
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
