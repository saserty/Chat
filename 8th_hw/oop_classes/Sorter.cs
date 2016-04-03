using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    public abstract class Sorter<T> : ISorter<T> where T : IComparable
    {
        protected T[] SortArray;

        public abstract void Sort();

        public void Swap(int a, int b)
        {
            T temp = SortArray[b];
            SortArray[b] = SortArray[a];
            SortArray[a] = temp;
        }

        public void Print()
        {
            foreach (T value in SortArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}
