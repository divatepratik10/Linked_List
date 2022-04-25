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

        public void Insert(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} Node Inserted to the Linked-List.", node.data);
        }

        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Linked-List is Empty.");
            }
            else
            {
                int delfirst = head.data;
                head = head.next;
                Console.WriteLine("{0} is Deleted from Linked-List.", delfirst);
            }
        }

        public void DeleteLast()
        {
            Node temp = head;
            if(head == null)
            {
                Console.WriteLine("Linked_List is empty.");
            }
            else if(head.next == null)
            {
                head = null;
            }
            while(temp.next.next != null)
            {
                temp = temp.next;
            }
            int delLast = temp.next.data;
            temp.next = null;
            Console.WriteLine("{0} is Deleted from Linked-List.", delLast);
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
