using System;

public class ReverseLinkedListRecursive
{
	
	public class Node
	{
		public int data;
		public Node next;

		public Node(int nodeData)
		{
			this.data = nodeData;
			this.next = null;
		}
	}

	class LinkedList
	{
		public Node head;

		public LinkedList()
		{
			this.head = null;
		}

		public void insertNode(int nodeData)
		{
			Node node = new Node(nodeData);

			if (this.head != null)
			{
				node.next = head;
			}
			this.head = node;
		}
	}


	public static void printSinglyLinkedList(Node node,
						String sep)
	{
		while (node != null)
		{
			Console.Write(node.data + sep);
			node = node.next;
		}
	}


	static Node reverse(Node head)
	{
		if(head == null)
		{
			return head;
		}

	
		if(head.next == null)
		{
			return head;
		}

		Node newHeadNode = reverse(head.next);

		
		head.next.next = head;
		head.next = null;

	
		return newHeadNode;
	}

	
	public static void Main(String[] args)
	{
			LinkedList llist = new LinkedList();
		
			llist.insertNode(20);
			llist.insertNode(4);
			llist.insertNode(15);
			llist.insertNode(85);
			
			Console.WriteLine("Given linked list:");
			printSinglyLinkedList(llist.head, " ");
			
			Console.WriteLine();
			Console.WriteLine("Reversed Linked list:");
			Node llist1 = reverse(llist.head);
			printSinglyLinkedList(llist1, " ");
	}
}


