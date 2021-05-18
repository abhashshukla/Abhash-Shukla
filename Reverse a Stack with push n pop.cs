using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program{
    
    public static class ReverseStack
    {
        
        public static Stack Reverse(Stack input)
        {
            Stack temp = new Stack();

            while (input.Count != 0)
                temp.Push(input.Pop());

            return temp;
        }
    }
    class Program
    {
        public static void Main()
        {
            Stack st = new Stack();

            st.Push(10);
            st.Push(5);
            st.Push(11);
            st.Push(7);
            st.Push(100);

            Console.WriteLine("\n..::Before reversing::..");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            st = ReverseStack.Reverse(st); 

            Console.WriteLine("\n..::After reversing::..");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}