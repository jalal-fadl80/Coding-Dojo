using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Dictionary<string,string> profile = new Dictionary<string,string>();
           profile.Add("Name","Speros");
           profile.Add("Language","PHP");
           profile.Add("Location","Greece");
           System.Console.WriteLine("        Instructor Profile");
           System.Console.WriteLine("        Name-" + profile["Name"]);
           System.Console.WriteLine("        From-" + profile["Location"]);
           System.Console.WriteLine("        Favourite language-" + profile["Language"]);
            foreach(KeyValuePair<string,string> entry in profile) {
             System.Console.WriteLine(entry.Key + " - " + entry.Value);
        
           }
        }
    }
}
