using System;

class fibo
{
    public static void Main()
    {
        int n1 = 0;
        int n2 = 1;
        int n3, i, len;

        Console.WriteLine("Enter the Length");
        len = int.Parse(Console.ReadLine());
        Console.WriteLine(n1 + " "+n2+" ");
        for (i = 2; i < len; i++)
        {
            n3 = n1 + n2;
            Console.WriteLine(n3);
            n1 = n2;
            n2 = n3;
        }
        Console.ReadLine();
    }
}
