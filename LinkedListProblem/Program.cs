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
                Console.WriteLine("Plase enter the option");
                Console.WriteLine("Select Option 1");
                Console.WriteLine("Select Option 2");
                Console.WriteLine("Select Option 3");
                Console.WriteLine("Select Option 4");
                Console.WriteLine("Select Option 5");
                Console.WriteLine("Select Option 6");
               
              
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
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.SearchElement(30);
                        linkedlist.SearchElement(70);
                        linkedlist.Display();
                        break;
                
                }
            }


        }
    }
}
