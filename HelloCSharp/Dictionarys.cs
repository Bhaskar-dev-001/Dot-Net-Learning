using System;
using System.Collections.Generic;

namespace Dictionarys
{
    class Program
    {
       public static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                {1, "Alice"},
                {2, "Bob"},
                {3, "Charlie"},
                {4, "Diana"}
            };

            for(int i =0; i<names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

        
        } 
    }
}