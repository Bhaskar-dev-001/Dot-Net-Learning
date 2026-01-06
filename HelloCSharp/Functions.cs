using System;

namespace Functions
{
    class Triangle
    {
        public static void Main(string[] args)
        {
            int width, length;
            Console.WriteLine("Enter the width of triangle:");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of triangle:");
            length = Convert.ToInt32(Console.ReadLine());

            int area = Area(width,length);
            Console.WriteLine("Area of triangle is: " + area);

        }


        public static int Area(int w, int l)
        {
            return (w*l)/2;
        }
    }
}