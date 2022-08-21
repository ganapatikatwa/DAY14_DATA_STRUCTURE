using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        Node head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.Next!=null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into LinkedList", node.data);
        }
       
        public void Display()
        {
            if (head == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The List Contains:");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Linked List Contains:");
                Console.ResetColor();
                Node tempnode = head;
                while (tempnode != null)
                {
                    Console.WriteLine(tempnode.data + "");
                    tempnode = tempnode.Next;
                }
            }
        }
        public void ReverseList()
        {
            Node prev = null;
            Node temp = head;
            Node next = null;

            while(temp!=null)
            {
                next=temp.Next;
                temp.Next = prev;
                prev = temp;
                temp = next;
            }
            head = prev;
        }

        public void Display2()
        {
            Node temp = head;
            while(temp!=null)
            { 
                Console.WriteLine(temp.data+" ");
                temp = temp.Next;
            }
        }
    }
}
