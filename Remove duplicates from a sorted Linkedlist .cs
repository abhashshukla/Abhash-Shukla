using System;
using System.Collections.Generic;
using System.Linq;


class RemoveDuplicates
{
    static void Main()
    {
     
      List<int> lst = new List<int>();
      lst.Add(1);
      lst.Add(2);
      lst.Add(3);
      lst.Add(3);

      System.Console.WriteLine("List with duplicates:");
      lst.ForEach(Console.WriteLine); 

      List<int> uniqueLst =lst.Distinct().ToList();
      
      System.Console.WriteLine("List after removing duplicates:");
      uniqueLst.ForEach(Console.WriteLine);
    }
}