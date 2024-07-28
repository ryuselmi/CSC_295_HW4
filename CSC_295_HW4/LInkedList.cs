using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSC295HW4.LinkedList
{
    public class LinkedList
    {
        public Node? First { get; set; }

        public void InsertFirst(int data)
        {
            Node newNode = new Node();

            newNode.Data = data;

            newNode.Next = First;

            First = newNode;
        }

        public Node DeleteFirst(int data)
        {
            if (First == null)
            {
                throw new InvalidOperationException("Cannot delete from an empty list.");
            }
            Node temp = First;
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating thru list...");
            Node? current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (First == null)
            {
                First = newNode;
            }
            else
            {
                Node current = First;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

    }
}
