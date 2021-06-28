using System;

namespace LineComparisionComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Problem");
            //initialising coordinates
            int x1, x2, y1, y2,p1,p2,q1,q2;
            double lineOneLength,lineTwoLength;
            //getting inputs from user for first line
            Console.WriteLine("Enter X-coordinate of First Point of First Line:");
            x1 = Convert.ToInt32(Console.ReadLine());//reading input and convert it to integer
            Console.WriteLine("Enter Y-coordinate of First Point First Line:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X-coordinate of Second Point First Line:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y-coordinate of Second Point First Line:");
            y2 = Convert.ToInt32(Console.ReadLine());

            //getting inputs from user for Second line 
            Console.WriteLine("Enter X-coordinate of First Point of Second Line:");
            p1 = Convert.ToInt32(Console.ReadLine());//reading input and convert it to integer

            Console.WriteLine("Enter Y-coordinate of First Point Second Line:");
            q1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter X-coordinate of Second Point Second Line:");
            p2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Y-coordinate of Second Point Second Line:");
            q2 = Convert.ToInt32(Console.ReadLine());

            //formula for calculate length
            lineOneLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            lineTwoLength = Math.Sqrt(Math.Pow(p2 - p1, 2) + Math.Pow(q2 - q1, 2));
            //Checking if line1 equals line 2 by Equals() and ternary operator 
            String result = lineOneLength.Equals(lineTwoLength) ? "Line one is equal to line Two" : "Line one is not equal to line Two";
            Console.WriteLine(result);



        }
    }
}
