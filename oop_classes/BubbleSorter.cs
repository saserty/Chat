using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    public class BubbleSorter<T> : Sorter<T>
    {
        public override void Sort(int[] array)
        {
            SortArray = array;
           int action1 = 0;
           do
            {
                action1 = 0;
                for (int i = 0; i < SortArray.Length - 1; i++)
                {
                    if (SortArray[i] > SortArray[i + 1])
                    {
                        Swap(i, i + 1);
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
        public void Print()
        { Print(); }
    }
}
