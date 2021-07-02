using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionComputation
{
    public class LineComparision
    {
        private int x1, x2, y1, y2;
        private double lineLength;
        //static list for storing lengths
        public static List<double> lengths = new List<double>();
        
        //normal constructor
        public LineComparision()
        {
            Console.WriteLine("Welcome to Line Comparision Computation Problem");
        }
        //parameterised constructor
        public LineComparision(int a1, int b1, int a2,int b2)
        {
            this.x1 = a1;
            this.y1 = b1;
            this.x2 = a2;
            this.y2 = b2;

            calculateLength();

        }

        //method for calculating length
        public void calculateLength()
        {
            
            lineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
            lengths.Add(lineLength);
            //Console.WriteLine(lengths[lengths.Count - 1]);
            //Console.WriteLine(lengths.Count);
        }
        
        //method for compare lines
        public void compareLines()
        {
            //Console.WriteLine(lengths.Count);
            //printing length of each line
            Console.WriteLine($"Line 1 Length: {lengths[0]}");
            Console.WriteLine($"Line 2 Length: {lengths[1]}");

            //uc1 using equals method
            Console.WriteLine("Checking Equality of line using Equals Method");
            String result = lengths[0].Equals(lengths[1]) ? "Line one is equal to line Two" : "Line one is not equal to line Two";
            Console.WriteLine(result);

            //uc2 using compare to method
            Console.WriteLine("Using CompareTo method check equality");
            int res = lengths[0].CompareTo(lengths[1]);
            if (res < 0)
            {
                Console.WriteLine("Line 1 is less than line 2");
            }
            else if (res == 0)
            {
                Console.WriteLine("Line 1 is equal to line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is greater than line 2");
            }
        }


    }
}
