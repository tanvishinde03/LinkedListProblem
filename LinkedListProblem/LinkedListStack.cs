using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedListStack
    {
        public Node top;
        public LinkedListStack()    //Constructor
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
                node.Next = null;
            else
                node.Next = this.top;
            this.top = node;
            Console.WriteLine(data);
        }
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("stack is ");
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine(" ");
        }
        public void Pop(int data)                                 // remove
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("value poped is " + this.top.Data);
            this.top = this.top.Next;
        }
    }
}


    

