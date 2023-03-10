using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)

                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into Linked List ", node.Data);
        }
        
        public void InReverse(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                node.Next = temp;
                head = node;
            }
            Console.WriteLine($"{node.Data} ");
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head != null)
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
                Console.WriteLine($"{node.Data} is added after the {temp.Data}");
            }
            else { head = node; }
        }

        public void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            this.head = this.head.Next;
            Console.WriteLine("the first element is deleted");
        }

        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("lined list is empty");
            }
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node laastNode = this.head;
                while (laastNode.Next.Next != null)
                {
                    laastNode = laastNode.Next;
                }
                laastNode.Next = null;
                Console.WriteLine("the last node is deleted");
            }
        }
        public void SearchElement(int data)
        {
            int count = 0;
            Node tempNode = this.head;
            if (tempNode == null)
                Console.WriteLine("Linke list is empty");
            else
            {
                while (tempNode != null)
                {
                    if (tempNode.Data.Equals(data))
                    {
                        count++;
                    }
                    tempNode = tempNode.Next;
                }
            }
            if (count > 0)
                Console.WriteLine(data + " data found " + count + ": time ");
            else
                Console.WriteLine(" data not found\n");
        }

        public void Size()
        {
            Node temp = head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty.");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.Next;
                count++;
            }
            Console.WriteLine("Count" + count);


            Console.ReadLine();



        }

            public void Display()
        {
            Node tempNode = this.head;
            if (tempNode == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Console.Write("Linked list is: ");
                while (tempNode != null)
                {
                    Console.Write(tempNode.Data + " ");
                    tempNode = tempNode.Next;
                }
                Console.WriteLine("\n");

            }




        }

    }
}

