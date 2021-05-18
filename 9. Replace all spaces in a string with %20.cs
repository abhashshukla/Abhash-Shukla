using System;
class Demo {
   static void Main() {
      String str, str2;
      str ="Hello World !";
      Console.WriteLine("String: "+str);
      str2 = str.Replace(" ", "%20");
      Console.WriteLine("String (After replacing): "+str2);
   }
}