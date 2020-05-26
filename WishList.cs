using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My wishes are...");
            List<string> wishes = new List<string>()
            {
                "great job", 
                "European vacation", 
                "baby hedgehog"
            };
            foreach (string wish in wishes)
            {
                Console.WriteLine(wish);
            }
        }      
    }
}