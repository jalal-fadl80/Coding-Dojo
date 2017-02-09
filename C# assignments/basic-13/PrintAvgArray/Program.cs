using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int[] myArray = {58,47,23,56,98,78};
            for (int i=1; i<myArray.Length; i++){
               sum+=myArray[i];
            }
               System.Console.WriteLine("The Average of the arrays is: " + sum/myArray.Length);
        }
        
    }
}
