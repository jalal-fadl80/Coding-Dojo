using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = {58,47,23,56,98,78};
            for (int i=1; i<myArray.Length; i++){
                System.Console.WriteLine("Index of " + i +" = "+ myArray[i]);
            }
        }
    }
}
