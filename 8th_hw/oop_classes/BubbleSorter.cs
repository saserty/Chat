using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    class BubbleSorter<T> : Sorter<T> where T : IComparable
    {        
        public BubbleSorter(T[] array)
        {
            SortArray = array;
        }
        public override void Sort()
        {           
           int action1 = 0;
           do
            {
                action1 = 0;
                for (int i = 0; i < SortArray.Length - 1; i++)
                {
                    if (SortArray[i].CompareTo(SortArray[i + 1]) > 0)
                    {
                        Swap(i, i + 1);
                        action1 = 1;
                    }
                }
            }
            while (action1 == 1);
        }
    }
}
