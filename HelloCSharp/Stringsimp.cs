using System;
using System.Threading;
namespace Stringsimp
{
    
    class StringImp
    {
        public static void Main(string[] args)
        {
            string message = "Hello this DotNet";

            for(int i=0; i<message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(100);
            }
Console.WriteLine();
         string fullMessage = " Learning";

         Console.WriteLine(string.Concat(message, fullMessage));

         Console.WriteLine(message.Contains("DotNet"));

      

        }

      
   
}
}