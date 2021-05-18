using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Demo {
   class ApplicationOne {
      static void Main(string[] args) {
         int n, i;
         Console.WriteLine("Enter the Number:");
         n = int.Parse(Console.ReadLine());
         Console.WriteLine("Factors:");
         for (i = 1; i <= n; i++) {
            if (n % i == 0) {
               Console.WriteLine(i);
            }
         }
         Console.ReadLine();
      }
   }
}