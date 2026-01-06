using System;

namespace Lists
{
    class Program
    {
        public static void Main(string[] args)
        {
            List <int> number = new List<int>();
            
            int nums = int.Parse(Console.ReadLine());
         
         for(int i=0; i<nums; i++)
            {
                number.Add(int.Parse(Console.ReadLine()));
            }
                foreach(int num in number)
            {
                Console.WriteLine("Element is "+num);
            }

        }
    }
}
