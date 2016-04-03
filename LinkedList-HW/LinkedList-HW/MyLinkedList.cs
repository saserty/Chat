using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_HW
{
    public class MyLinkedList<T>
    {
        private class MyNode
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
        public void PrintLL()
        {
            MyNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
