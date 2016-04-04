using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_HW
{
    class LLStack <T>
    {
        MyLinkedList<T> LLinStack = new MyLinkedList<T>();

        public bool IsEmpty()
        {
            if (LLinStack.ListIsEmpty())
            {
                return true;
            }
            return false;
        }
        
        public void Push (T data)
        {
            LLinStack.AddToEnd(data);
        }

        public T Pop()
        {
            T SomePop;
            if (!IsEmpty())
            {
                SomePop = LLinStack.RemoveFromLL();
                return SomePop;
            }
            return default(T);
        }

        public T Peek()
        {
            T SomePeek;
            if (!IsEmpty())
            {
                SomePeek = LLinStack.GetLast();
                return SomePeek;
            }
            return default(T);
        }
    }
}
