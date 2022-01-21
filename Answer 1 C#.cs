using System;  
  
namespace Fibonacci 
{  
 class MainClass  
 {  
  public static void Main (string[] args)  
  {  
  
   int a, b = 1, result = 0;  


   for(int i = 0; i<100; i++)
   {  
    a = b;  
    b = result; 
    result = a + b;
    
    if(result<1000 && result>0) 
    {
        Console.WriteLine(result); 
    }
    else
    {
        continue;
    } 
    }  
   }  
 }  
}  