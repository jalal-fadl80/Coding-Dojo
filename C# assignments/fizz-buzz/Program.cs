using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1 ; i <=100 ; i++){
                if (i % 3 == 0){
                    System.Console.Write("Fizz  ");
                }
                else if (i % 5 == 0){
                    System.Console.Write("Buzz  ");
                }
                else if (i % 3 == 0 && i % 5 == 0){
                    System.Console.Write("Fizz - Buzz ");
                }
            }
        }
    }
}
