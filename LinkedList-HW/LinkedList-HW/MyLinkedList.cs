using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_HW
{
    public class MyLinkedList<T> //: IEnumerable
    {
        public class MyNode
        {
            public T data;
            public MyNode next;
        }
        
        private MyNode head = null;

        public void AddToEnd(T data)
        {
            if (head == null)
            {
                head = new MyNode();

                head.data = data;
                head.next = null;
            }
            else
            {
                MyNode NewNode = new MyNode();
                NewNode.data = data;

                MyNode current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = NewNode;
            }
        }
        
        public T RemoveFromLL()
        {
            T removeItem = head.data;
            head = head.next;
            return removeItem;
        }

        public bool ListIsEmpty()
        {
            if (head==null)
            {
                return true;
            }
            return false;
        }

        public void PrintLL()
        {
            MyNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public T GetLast()
        {
            MyNode result = head;

            if (result == null)
                return default(T);

            while (true)
            {
                if (result.next != null)
                {
                    result = result.next;
                }
                else
                {
                    return result.data;
                }
            }
        }
    }
}
