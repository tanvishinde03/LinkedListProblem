using System;
using System.Collections.Generic;
using System.Linq;
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
                while (temp.next != null)

                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List ", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            Console.WriteLine("Linked list is: ");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.ReadLine();
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
                node.next = temp;
                head = node;
            }
            Console.WriteLine($"{node.data} ");
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head != null)
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine($"{node.data} is added after the {temp.data}");
            }
            else { head = node; }
        }

        public void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            this.head = this.head.next;
            Console.WriteLine("the first element is deleted");
        }

        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("lined list is empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                Node laastNode = this.head;
                while (laastNode.next.next != null)
                {
                    laastNode = laastNode.next;
                }
                laastNode.next = null;
                Console.WriteLine("the last node is deleted");
            }
        }


    }
}
    

    

