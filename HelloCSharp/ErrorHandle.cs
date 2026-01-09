using System;

namespace ErrorHandle
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 23,b=0;
            try
            {
                if (a / b == 0)
                {
                    Console.WriteLine("Result is "+ a/b);
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution Completed.");
            }   
        }
    }
}
