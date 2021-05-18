using System;

public class LinkedList
{
	public Node head; 


	public class Node
	{
		public int data;
		public Node next;
		public Node(int d)
		{
			data = d;
			next = null;
		}
	}

	
	void printNthFromLast(int n)
	{
		int len = 0;
		Node temp = head;

	
		while (temp != null)
		{
			temp = temp.next;
			len++;
		}

		
		if (len < n)
			return;

		temp = head;

		
		for (int i = 1; i < len - n + 1; i++)
			temp = temp.next;

		Console.WriteLine(temp.data);
	}

	
	public void push(int new_data)
	{
	
		Node new_node = new Node(new_data);

		
		new_node.next = head;

		
		head = new_node;
	}


	public static void Main(String[] args)
	{
		LinkedList llist = new LinkedList();
		llist.push(20);
		llist.push(4);
		llist.push(15);
		llist.push(35);

		llist.printNthFromLast(4);
	}
}


