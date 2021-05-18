using System;
  
class STAIRS {
    
    static int fib(int n)
    {
        if (n <= 1)
            return n;
        return fib(n - 1) + fib(n - 2);
    }
  
    
    static int countWays(int s)
    {
        return fib(s + 1);
    }
  
    
    static public void Main()
    {
        int s = 6;
        Console.WriteLine("Number of ways = " + countWays(s));
    }
}