using System;
 
class GFG
{
 

static String reverseStr(String str)
{
    int n = str.Length;
 
    
    
    for (int i = 0; i < n / 2; i++)
        str = swap(str,i,n - i - 1);
    return str;
}
static String swap(String str, int i, int j)
{
    char []ch = str.ToCharArray();
    char temp = ch[i];
    ch[i] = ch[j];
    ch[j] = temp;
    return String.Join("",ch);
}
 

public static void Main(String[] args)
{
    string str = "geeksforgeeks";
    str= reverseStr(str);
    Console.WriteLine(str);
}
}