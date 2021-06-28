using System;

namespace LineComparisionComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Problem");
            //initialising coordinates
            int x1, x2, y1, y2;
            double length;
            //getting inputs from user
            Console.WriteLine("Enter X-coordinate of First Point:");
            x1 = Convert.ToInt32(Console.ReadLine());//reading input and convert it to integer
            Console.WriteLine("Enter Y-coordinate of First Point:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X-coordinate of Second Point:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y-coordinate of Second Point:");
            y2 = Convert.ToInt32(Console.ReadLine());

            //formula for calculate length
            length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(length);

            
        }
    }
}
