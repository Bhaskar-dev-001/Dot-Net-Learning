using System;

namespace Structures{
        class Program
    {
        
            
      public  struct Person  {
            public int ID;
            public string name;
            public int Age;

            public  Person(int ID,string name,int Age)
            {
                this.ID = ID;
                this.name = name;
                this.Age = Age;
            }
        }
        
        public static void Main(string []args)
        {
       
    
     Person person = returnPerson();

     
     Console.WriteLine("Person Details:");
        Console.WriteLine("ID: " + person.ID);
        Console.WriteLine("Name: " + person.name);
        Console.WriteLine("Age: " + person.Age);
        }


          public static Person returnPerson()
        {
            Console.WriteLine("Enter your ID");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter yor Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Age");
            int Age = Convert.ToInt32(Console.ReadLine());

            return new Person(ID,name,Age);



        }
    }
}


    


