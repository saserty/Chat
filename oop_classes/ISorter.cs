using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    public interface ISorter<T> : IPrintable
    {
        void Sort(int[] SortArray);
        void Swap(int a, int b);
    }
}
