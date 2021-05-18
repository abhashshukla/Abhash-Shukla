using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Demo {
   public bool CheckUnique(string str) {
      string one = "";
      string two = "";
      for (int i = 0; i < str.Length; i++) {
         one = str.Substring(i, 1);
         for (int j = 0; j < str.Length; j++) {
            two = str.Substring(j, 1);
            if ((one == two) && (i != j))
            return false;
         }
      }
      return true;
   }
   static void Main(string[] args) {
      Demo d = new Demo();
      bool b = d.CheckUnique("abhash");
      Console.WriteLine(b);
      Console.ReadKey();
   }
}