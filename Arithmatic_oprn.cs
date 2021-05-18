using System;

namespace OperatorsApplication {
   class Program {
      static void Main(string[] args) {
         int a = 40;
         int b = 20;
         int c;

         c = a + b;
         Console.WriteLine("Addition: {0}", c);

         c = a - b;
         Console.WriteLine("Subtraction: {0}", c);
     
         c = a * b;
         Console.WriteLine("Multiplication: {0}", c);

         c = a / b;
         Console.WriteLine("Division: {0}", c);

         Console.ReadLine();
      }
   }