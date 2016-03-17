using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    public abstract class Sorter<T> : ISorter<T>, IComparable
    {
        protected int[] SortArray;
        public void Initialize<T>(T[] SortArray) where T : new()
        {
            for (int i = 0; i < SortArray.Length; i++)
            SortArray[i] = new T();
        }
        public abstract void Sort(int[] SortArray);
        public void Swap(int a, int b)
        {
            int temp = SortArray[b];
            SortArray[b] = SortArray[a];
            SortArray[a] = temp;
        }
        public void Print(int[] SortArray)
        {
            foreach (int value in SortArray)
            {
                Console.WriteLine(value);
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
