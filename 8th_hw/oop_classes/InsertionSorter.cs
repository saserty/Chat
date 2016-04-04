using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    class InsertionSorter<T> : Sorter<T> where T : IComparable
    {
        public InsertionSorter(T[] array)
        {
            SortArray = array;
        }
        public override void Sort()
        {
            int action1 = 0;
            int action2 = 0;
            do
            {
                action1 = 0;
                action2 = 0;
                for (int i = 1; i < SortArray.Length; i++)
                {
                    if (i == 0)
                    {
                        i = 1;
                    }
                    else if ((SortArray[i].CompareTo(SortArray[i - 1])) < 0 && i > 0) //((SortArray[i] < SortArray[i - 1]) && i > 0)
                    {
                        Swap(i, i - 1);
                        action1 = 1;
                        i = i - 2;
                    }
                    else
                    {
                        action2 = 1;
                    }
                }
            }
            while (action1 == 1 && action2 == 1);
        }
    }
}
