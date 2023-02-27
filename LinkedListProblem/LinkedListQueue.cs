using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedListQueue
    {
        public Node front;
        public Node tail;

        public LinkedListQueue()                //constructor
        {
            this.front = null;
            this.tail = null;
        }
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (tail == null)
            {
                tail = node;
                front = node;
            }
            else
            {
                node.Next = tail;
                tail = node;
            }
            Console.WriteLine($"{data} is added in queue");
        }
        public void Dequeue()
        {
            if (tail != null)
            {
                if (tail.Next == null)
                {
                    tail = null;
                }
                else
                {
                    Node temp = tail;
                    while (temp.Next.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = null;
                    front = temp;
                }
            }
            Display();
        }
        public void Display()
        {
            Node temp = tail;
            Console.WriteLine("The Stack:\n");
            while (temp != null)
            {
                Console.Write($" {temp.Data} ");
                temp = temp.Next;
            }
        }


    }
}




