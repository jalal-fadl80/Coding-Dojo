using System;

namespace ConsoleApplication
{
    public class Program
    {
       
        public static void Main(string[] args)
        
        {
            int sum = 0;
            for (int i = 1 ; i <256 ;i++){
                 sum+=i;
                 System.Console.Write(" i ="+"  " +i + " Sum = "+sum);

            }
        }
    }
}
