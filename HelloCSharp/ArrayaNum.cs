using System;
using System.Collections.Generic;


namespace ArrayaNum
{
    class Table
    {
        public static void Main(string[] args)
        {
            int num,len;
            num = 5;
            len = 5;
            int [] table  = new int[len];

            for(int i=0; i<len; i++)
            {
                table[i]= num*i;

            }

            foreach(int t in table)
            {
                Console.WriteLine("table of "+num+" is "+t);
            }

        }
    }
}