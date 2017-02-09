using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i=1 ; i < 256 ; i++){
                if (i % 2 != 0){
                    System.Console.Write(" - "+i);
                }
            }
        }
    }
}
