using System;

  namespace Conditions

{
    class Condition
    {
              public static void Main(string[] args){

                int a=100,c=20;

                int div = a%c;
              

            if (div ==0)
            {
                Console.WriteLine("the nubmer is divisible");
            }
            else{
                Console.WriteLine("The Number is Not Disvisible");
            }


                Console.WriteLine("Enter the day");
             int day = int.Parse( Console.ReadLine());

            switch (day)
            {
                case 1 : Console.WriteLine("Monday");
                      break;
                 case 2 : Console.WriteLine("TUE");
                      break;

                  case 3 : Console.WriteLine("WED");
                      break; 

                     case 4 : Console.WriteLine("THU");
                      break;
                       case 5 : Console.WriteLine("FRI");
                      break;
                       case 6 : Console.WriteLine("SAT");
                      break;
                       case 7 : Console.WriteLine("SUN");
                      break;          

                      default: Console.WriteLine("Wrong number enter the number between 1 to 7");
                      break;

             

            }
            
        }

    }
    
}