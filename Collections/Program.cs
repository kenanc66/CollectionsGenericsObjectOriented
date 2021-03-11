using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"k","a","c" };
            Console.WriteLine(names[2]);
            names.Add("kenan");
            Console.WriteLine(names[3]);
            
        }
    }
}
