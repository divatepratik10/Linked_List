using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structure Programme.");
            Console.WriteLine("Choose any one method\n0 : Basic Linked list (Built-In)\n1 : Linked List");
            int input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
                case 0:
                    LinkedList<string> list = new LinkedList<string>();
                    list.AddLast("Rajkumar");
                    list.AddLast("Divate");
                    list.AddFirst("Pratik");
                    foreach(string item in list)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 1:
                    CustomLinkedList LinkedList = new CustomLinkedList();
                    LinkedList.Append(56);
                    LinkedList.Append(30);
                    LinkedList.Append(70);
                    LinkedList.Display();
                    break;

                default:
                    Console.WriteLine("Enter a valid Input.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
