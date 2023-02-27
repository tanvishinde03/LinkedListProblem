using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n Plase enter the option");
                Console.WriteLine("Select Option 1");
                Console.WriteLine("Select Option 2");
                Console.WriteLine("Select Option 3");
                Console.WriteLine("Select Option 4");
                Console.WriteLine("Select Option 5");
                Console.WriteLine("Select Option 6");
                Console.WriteLine("Select Option 7");
                Console.WriteLine("Select Option 8");
                Console.WriteLine("Select Option 9");
                Console.WriteLine("Select Option 10");
                Console.WriteLine("Select Option 11");
                Console.WriteLine("Select Option 12");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        break;
                    
                    case 2:
                        linkedlist.InReverse(56);
                        linkedlist.InReverse(30);
                        linkedlist.InReverse(70);
                        break;
                    case 3:
                        linkedlist.Append(56);
                        linkedlist.Append(30);
                        linkedlist.Append(70);
                        break;
                    case 4:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.RemoveFirstNode();
                        break;
                    case 5:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.RemoveLastNode();
                        linkedlist.Display();
                        break;
                    case 6:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.SearchElement(30);
                        linkedlist.SearchElement(70);
                        linkedlist.Display();
                        break;
                    case 7:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.Display();
                        linkedlist.Add(40);
                        linkedlist.Size();
                        linkedlist.Display();
                        break;
                    case 8:
                        linkedlist.Display();
                        break;
                    case 9:
                        stack.Push(10);
                        stack.Push(20);
                        stack.Push(30);
                        stack.Display();
                        break;
                    case 10:
                        stack.Push(10);
                        stack.Push(20);
                        stack.Push(30);
                        stack.Display();
                        stack.Pop(20);
                        stack.Display();
                        break;
                    case 11:
                        queue.Enqueue(10);
                        queue.Enqueue(20);
                        queue.Enqueue(30);
                        queue.Display();
                        break;
                    case 12:
                        queue.Dequeue();
                        break;
                    case 13:
                        queue.Display();
                        break;
                }
            }


        }
    }
}
