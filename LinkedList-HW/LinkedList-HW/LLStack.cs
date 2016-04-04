using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_HW
{
    class LLStack <T>
    {
        protected T[] myStackArray;
        protected int topPossition = 0;

        public DynamicStack()
        {
            myStackArray = new T[4];
        }

        private int Capacity
        {
            get
            {
                return myStackArray.Length;
            }
        }
        
        public bool IsFull()
        {
            if (topPossition == Capacity)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (topPossition == 0)
            {
                Console.WriteLine("The Array is empty");
                return true;
            }
            return false;
        }

        public void Push(T element)
        {
            if (!IsFull())
            {
                myStackArray[topPossition] = element;
                Console.WriteLine("The new element {0} was sucessfully added to Stack", element);
                topPossition++;
            }
            else
            {
                Resize();
                myStackArray[topPossition] = element;
                topPossition++; 
            }
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                 Console.WriteLine("The last element {0} was sucessfully removed from Stack", myStackArray[topPossition - 1]);
                topPossition--;
                return myStackArray[topPossition];
            }
            else { return default (T); }
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("The last element in Stack is {0}", myStackArray[topPossition - 1]);
                return myStackArray[topPossition - 1];
            }
            else { return default (T); }
        }
        
        private void Resize()
        {
            T[] resizeArray = new T[Capacity * 2];

            for (int i = 0; i < myStackArray.Length; i++)
            {
                resizeArray[i] = myStackArray[i];

            }

           myStackArray = resizeArray;
       }
    }
}
