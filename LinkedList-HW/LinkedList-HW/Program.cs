using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Select action");
            //Console.WriteLine("1. Create new Node");
            //Console.WriteLine("2. Add new Node to the end of LinkedList");
            //Console.WriteLine("3. Work with Stack");
            //Console.Write("Selected action: ");
            //int method = Int32.Parse(Console.ReadLine());

            //switch (method)
            //{
            //    case 1:
            //        MyNode();
            //        break;
            //    case 2:
            //        MyLinkedList();
            //        break;
            //    case 3:
            //        LLStack();
            //        break;
            //}
            MyLinkedList<int> NewList = new MyLinkedList<int>();
            Console.WriteLine("Add to the end: ");
            NewList.AddToEnd(111);
            NewList.AddToEnd(222);
            NewList.AddToEnd(333);
            NewList.AddToEnd(444);
            NewList.AddToEnd(555);
            Console.WriteLine("Print");
            NewList.PrintLL();
            Console.WriteLine("Peek");
            Console.WriteLine(NewList.GetLast());
            
            Console.ReadKey();
        }
    }
}
