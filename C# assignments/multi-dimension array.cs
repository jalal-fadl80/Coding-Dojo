using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
          int[ ] numbers = new int[10] {1,2,3,4,5,6,7,8,9,10};
          int[ ] numbers1 = new int[10] {1,2,3,4,5,6,7,8,9,10};
          int[,] multiArray = new int[10,10];
         for (int i =0 ; i< numbers.Length ; i++ ){
             for (int j =0 ; j< numbers1.Length ; j++){
                 System.Console.Write(multiArray[i,j] = numbers[i] * numbers1[j] );  
             } 
             System.Console.WriteLine();
         }
        }
        }
    }

