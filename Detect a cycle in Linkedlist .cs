using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }
        public Node(int value)
        {
            this.Value = value;
        }

    }
    public class LinkedList
    {
        private Node _head;
        public LinkedList()
        {

        }
        public void AppendLast(Node newNode)
        {
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                Node current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public override string ToString()
        {
            Node current = _head;
            StringBuilder builder = new StringBuilder();
            while (current != null)
            {
                builder.Append(current.Value + "->");
                current = current.Next;
            }
            return builder.ToString();
        }
        public bool IsCycle()
        {
            Node slow = _head;
            Node fast = _head;
            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
                if (slow == fast)
                    return true;
            }
            return false;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AppendLast(new Node(10));
            list.AppendLast(new Node(20));
            list.AppendLast(new Node(30));
            Node cycle = new Node(40);
            list.AppendLast(cycle);
            list.AppendLast(new Node(60));
            list.AppendLast(cycle);

            if (list.IsCycle())
            {
                Console.WriteLine("Linked List is cyclic as it contains cycle or loop");
            }
            else
            {
                Console.WriteLine("LinkedList is not cyclic, no loop or cycle found");
            }



        }
    }
}