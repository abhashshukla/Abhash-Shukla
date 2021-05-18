using System;
class TOWER
{
    static void towerOfHanoi(int n, char from_bar, char to_bar, char aux_bar)
    {
        if (n == 1)
        {
            Console.WriteLine("Move disk 1 from rod " + 
                              from_bar + " to rod " + to_bar);
            return;
        }
        towerOfHanoi(n-1, from_bar, aux_bar, to_bar);
        Console.WriteLine("Move disk " + n + " from rod " + 
                          from_bar + " to rod " + to_bar);
        towerOfHanoi(n-1, aux_bar, to_bar, from_bar);
    }
     
    public static void Main(String []args)
    {
        int n = 5; 
        towerOfHanoi(n, 'A', 'C', 'B');  
    }
}