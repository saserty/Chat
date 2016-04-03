using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    public interface ISorter<T> : IPrintable<T> where T : IComparable
    {
        void Sort();
        void Swap(int a, int b);
    }
}
