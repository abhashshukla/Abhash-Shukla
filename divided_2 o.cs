using System;
namespace Program {
   class Demo {
      public int RemainderFunc(int val1, int val2) {
         if (val2 == 0)
         throw new Exception("Second number cannot be zero! Cannot divide by zero!");
         if (val1 < val2)
         throw new Exception("Number cannot be less than the divisor!");
         else
         return (val1 % val2);
      }
      static void Main(string[] args) {
         int one = 250;
         int two = 200;
         int remainder;
         Console.WriteLine("Number One: "+one);
         Console.WriteLine("Number Two: "+two);
         Demo d = new Demo();
         remainder = d.RemainderFunc(one, two);
         Console.WriteLine("Remainder: {0}", remainder );
         Console.ReadLine();
      }
   }
}