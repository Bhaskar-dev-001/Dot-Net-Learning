using System;

namespace Arrays
{
    class Arrays
    {
        public static void Main(string[] args)
         {
        //     int []arr= new int[5];

        //        Console.WriteLine("Enter the 5 elements");
        //        arr[0] = int.Parse(Console.ReadLine());
        //        Console.WriteLine("1st "+arr[0]);
        //        arr[1] = int.Parse(Console.ReadLine());
        //        Console.WriteLine("2nd "+arr[1]);
        //        arr[2] = int.Parse(Console.ReadLine()); 
        //        Console.WriteLine("3rd "+arr[2]);
        //        arr[3] = int.Parse(Console.ReadLine());
        //         Console.WriteLine("4th "+arr[3]);
        //        arr[4] = int.Parse(Console.ReadLine()); 
        //         Console.WriteLine("5th "+arr[4]); 

        //     for(int i=0; i<arr.Length; i++)
        //     {
        //         arr[i] = int.Parse(Console.ReadLine());
             
        //     }

        //     for(int i=0; i<arr.Length; i++)
        //     {
        //         Console.WriteLine("Element at index "+i+" is "+arr[i]);
        //     }

        //        foreach(int num in arr)
        //     {
        //         Console.WriteLine("Element is "+num);
        //     }

        int []arr  = [45,34,23,56,56];
        arr.Sort();
        foreach(int num in arr)
        {
            Console.WriteLine("Element is "+num);
        }
Console.WriteLine("After Reversing");
      
      Array.Reverse(arr); 
        foreach(int num in arr)
        {
            Console.WriteLine("Element is "+num);
        }

    }
    }
}
