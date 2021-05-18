using System;
using System.Linq;
using System.Collections.Generic;

namespace Demo {
   class Program {
      static void Main(string[] args) {
         string myStr = "kkllmmnnoo";
         Console.WriteLine("Initial String: "+myStr);
         var unique = new HashSet<char>(myStr);
         Console.Write("New String after removing duplicates: ");
         foreach (char c in unique)
         Console.Write(c);
      }
   }
}