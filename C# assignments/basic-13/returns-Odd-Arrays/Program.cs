using System;
using System.Linq;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
             int[] oddArray =new int[255];
             for (int i=1; i<oddArray.Length; i++){
                 if (i % 2 != 0){
                oddArray[i] = i ;
        }
        System.Console.WriteLine(oddArray);
             }
        }
    }
}

