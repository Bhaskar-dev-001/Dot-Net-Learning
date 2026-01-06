using System;

namespace Password
{
    class Password
    {
        public static void Main(string[] args)
        {
            string password, Repassword;

            Console.WriteLine("Enter the Password");
          password =  Console.ReadLine();
            if (password.Equals(""))
            {
                Console.WriteLine("Password cannot be empty");
            
                return;
            }
            Console.WriteLine("Enter the Password again");
            Repassword = Console.ReadLine();
            if(Repassword.Equals(""))
            {
                Console.WriteLine("Re-Password cannot be empty");
                return;
            }

            if (password.Equals(Repassword))
            {
                Console.WriteLine("Password Match");
            }
            else
            {
                Console.WriteLine("Password Does Not Match");
            }

           

        }
    }
}