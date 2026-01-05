using System;

namespace Table
{
    class Table
    {
        public static void Main(string[] args)
        {
            // To Print A Table of any Number 
            Console.WriteLine("Enter the Number");
            int num =  int.Parse(Console.ReadLine());
              
              for(int i=0; i<=10; i++)
            {
                int table = num *i;

                Console.WriteLine(num +" * " +i+" =  "+table );
            }


        }
    }
}