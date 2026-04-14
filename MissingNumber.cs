// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        int[] nums = new int[] {9,6,4,2,3,5,7,0,1};
        int n= nums.Length;
         int expectedSum = n * (n + 1) / 2;
         int actualSum = 0;
         
         foreach(var sum in nums){
             actualSum += sum;
         }
         
        Console.WriteLine ("Missing number" + " = "  + (expectedSum - actualSum));
    }
}
