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
            Console.WriteLine("Choose any one method\n0 : Basic Linked list (Built-In)\n1 : Linked List\n2 : Delete First element of List" +
                "\n3 : Delete Last element");
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
                    LinkedList.AddLast(56);
                    //LinkedList.Append(30);
                    LinkedList.AddLast(70);
                    LinkedList.Insert(2, 30);
                    Console.WriteLine("Elements in the Linked_List are : ");
                    LinkedList.Display();
                    break;

                case 2:
                    CustomLinkedList List = new CustomLinkedList();
                    List.AddLast(30);
                    List.AddLast(70);
                    List.AddFirst(56);
                    List.DeleteFirst();
                    Console.WriteLine("Elements in the Linked_List are : ");
                    List.Display();
                    break;

                case 3:
                    CustomLinkedList List1 = new CustomLinkedList();
                    List1.AddLast(30);
                    List1.AddLast(70);
                    Console.WriteLine("Elements in the Linked_List are : ");
                    List1.AddFirst(56);
                    List1.Display();
                    List1.DeleteLast();
                    Console.WriteLine("Elements in the Linked_List after deletion are : ");
                    List1.Display();
                    break;
                default:
                    Console.WriteLine("Enter a valid Input.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
