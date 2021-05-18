using System;

public class Program {
   public static void Main(string[] args) {
      int dec;
      Demo d = new Demo();
      dec = 85;
      Console.Write("Decimal = "+dec);
      Console.Write("\nBinary of {0} = ", dec);
      d.displayBinary (dec);
      Console.ReadLine();
      Console.Write("\n");
   }
}
public class Demo {
   public int displayBinary(int dec){
      int res;
      if (dec != 0) {
         res = (dec % 2) + 10 * displayBinary(dec / 2);
         Console.Write(res);
         return 0;
      } else {
         return 0;
      }
   }
}