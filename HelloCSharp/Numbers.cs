using System;
using System.Collections.Generic;

namespace Numbers
{
    class EvenOdd
    {
        public static void Main(string []args){
        List<int>EvenNum = new List <int>();
        List <int> OddNum = new List<int>();

        for(int i=0; i<20; i++)
            {
                if (i % 2== 0)
                {
                    EvenNum.Add(i);
                }
                else
                {
                    OddNum.Add(i);
                }
            }

            foreach(int even in EvenNum)
            {
               Console.WriteLine("Even Numbers"+even); 
            }

            foreach(int odd in OddNum)
            {
                Console.WriteLine("Odd Numbers"+ odd);
            }




        }

    }
}