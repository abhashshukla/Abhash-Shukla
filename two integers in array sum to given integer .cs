using System;
using System.Collections.Generic;

namespace Demo {
   public class Program {
      public static void Main(string[] args) {
         int[] arr = new int[] {
            7,
            4,
            6,
            2
         };
         
         int res = 8;
         Console.WriteLine("Given Integer {0}: ", res);
         Console.WriteLine("Sum of:");
         for (int i = 0; i < arr.Length; i++) {
            for (int j = 0; j < arr.Length; j++) {
               if (i != j) {
                  int sum = arr[i] + arr[j];
                  if (sum == res) {
                     Console.WriteLine(arr[i]);
                  }
               }
            }
         }
      }
   }
}