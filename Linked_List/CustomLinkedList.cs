using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    internal class CustomLinkedList
    {
        public Node head;

        public void AddLast(int data)
        {
            Node NewNode = new Node(data);
            if(head == null)
            {
                head = NewNode;
            }
            else
            {
                Node LastNode = GetLastNode();
                LastNode.next = NewNode;
            }
            Console.WriteLine("{0} Node added to the Linked-List.", NewNode.data);
        }

        private Node GetLastNode()
        {
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void AddFirst(int NewData)
        {
            Node New_Node = new Node(NewData);
            New_Node.next = this.head;
            this.head = New_Node;
            Console.WriteLine("{0} Node added to the Linked-List.", New_Node.data);
        }

        public void Append(int Newnode)
        {
            AddLast(Newnode);
        }

        public void Display()
        {
            Console.WriteLine("Displying Linked-List nodes.");
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked List is Empty.");
            }
            while(temp != null)
            {
                Console.WriteLine(" "+temp.data+" ");
                temp = temp.next;
            }
        }
    }
}
