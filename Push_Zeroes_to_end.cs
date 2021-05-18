sing System;
 
class PushZero
{
    
    static void pushZerosToEnd(int []arr, int n)
    {
        int count = 0;
         
        for (int i = 0; i < n; i++)
        if (arr[i] != 0)
         
        
        arr[count++] = arr[i];
         
        
        while (count < n)
        arr[count++] = 0;
    }
     
    
    public static void Main ()
    {
        int []arr = {1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9};
        int n = arr.Length;
        pushZerosToEnd(arr, n);
        Console.WriteLine("Array after pushing all zeros to the back: ");
        for (int i = 0; i < n; i++)
        Console.Write(arr[i] +" ");
    }
}