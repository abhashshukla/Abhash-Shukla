using System;  
  public class ArmstrongExample  
   {  
     public static void Main(string[] args)  
      {  
       int  n,r,result=0,temp;      
       Console.Write("Enter the Number= ");      
       n= int.Parse(Console.ReadLine());     
       temp=n;      
       while(n>0)      
       {      
        r=n%10;      
        result=result+(r*r*r);      
        n=n/10;      
       }      
       if(temp==result)      
        Console.Write("Armstrong Number.");      
       else      
        Console.Write("Not Armstrong Number.");      
      }  
  }  