using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // string[] mycars = new string[4] {"Mazda","Ford","Toyota","Nissan"};
            //foreach(string car in mycars){
               //cls System.Console.WriteLine("I own a {0}",car);
            List<String> bikes = new List<String>();
            bikes.Add("Kawazaki");
            bikes.Add("BMW");
            bikes.Add("Toyota");
            bikes.Add("Nissan");
            bikes.Add("Ford");
            bikes.Add("Giad");
            bikes.Add("Honda");
            for (int i = 0 ; i < bikes.Count ; i++){
                System.Console.WriteLine("  "+ i + " - " + bikes[i]);
            }
             System.Console.WriteLine("We Currently know {0} types of bikes",bikes.Count);
             bikes.Insert(2,"Ferrary");
             bikes.Remove("Ford");
             bikes.Remove("Giad");
             bikes.RemoveAt(0);
             foreach (string veh in bikes){
                 System.Console.WriteLine(" - " + veh);
             }
            }
        }
    }