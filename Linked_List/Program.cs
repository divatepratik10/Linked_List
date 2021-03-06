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
                "\n3 : Delete Last element\n4 : Search Whether element is present in list or not\n5 : Delete node from list");
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
                    LinkedList.AddFirst(56);
                    LinkedList.AddLast(30);
                    LinkedList.AddLast(70);
                    LinkedList.Insert(3, 40);
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

                case 4:
                    CustomLinkedList List2 = new CustomLinkedList();
                    List2.AddLast(30);
                    List2.AddLast(70);
                    List2.AddFirst(56);
                    Console.WriteLine("Enter element to search if it is present in list or not : ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    List2.Search(value);
                    break;

                case 5:
                    CustomLinkedList NewList = new CustomLinkedList();
                    NewList.AddLast(30);
                    NewList.AddLast(70);
                    NewList.AddFirst(56);
                    NewList.Insert(3, 40);
                    Console.WriteLine("Before Delete List is : ");
                    NewList.Display();
                    NewList.Delete(40);
                    Console.WriteLine("After Deletion List is : ");
                    NewList.Display();
                    break;
                default:
                    Console.WriteLine("Enter a valid Input.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
