using System;
using System.IO;

public class Demo {
   public static void Main(string[] args) {
      int n = 5;
      int p = 2;
      long res;
      res = power(n, p);
      Console.WriteLine(res);
   }

   static long power (int n, int p) {
      if (p!=0) {
         return (n * power(n, p - 1));
      }
      return 1;
   }
}