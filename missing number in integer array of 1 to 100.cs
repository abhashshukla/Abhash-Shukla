using System;
using System.LINQ;
class Find_Missing_Number
    {
        static void Main(string[] args)
        {
            
            int[] arr = Enumerable. Range(1, 100). ToArray(); 

            int missingNumber,Totalsum;
            
            Totalsum = (arr.Length + 1) * (arr.Length + 2) / 2;

            foreach (int item in arr)
            {
                Totalsum = Totalsum - item;
            }
            missingNumber = Totalsum;

            Console.WriteLine("missing number  : {0}",missingNumber);
        }
    }
