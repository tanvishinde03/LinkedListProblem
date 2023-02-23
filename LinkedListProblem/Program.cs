using System;
using System.Collections.Generic;
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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Plase enter an object an option");
                Console.WriteLine("Select Option 1");
                Console.WriteLine("Select Option 2");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        break;
                    case 2:
                        linkedlist.Display();
                        break;
                    default:
                        Console.WriteLine("Enter correct option");
                        break;
                }
            }


        }
    }
}
