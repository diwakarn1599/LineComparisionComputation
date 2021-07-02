using System;

namespace LineComparisionComputation
{
    class Program
    {
        //intialising object for line comparision
        LineComparision lc;

        //method for initialize constructor
        private  void computeLength(int x1, int y1,int  x2,int y2)
        {
            
            lc = new LineComparision(x1,y1,x2,y2);
        }
        static void Main(string[] args)
        {
            
            
            int x1, x2, y1, y2;
            //object for program class
            Program pg = new Program();
            for(int i = 1; i <= 2; i++)
            {
                
                Console.WriteLine($"Enter X-coordinate of First Point Line {i}:");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter Y-coordinate of First Point Line {i}:");
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter X-coordinate of Second Point Line {i}:");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter Y-coordinate of Second Point Line {i}:");
                y2 = Convert.ToInt32(Console.ReadLine());

                //calling method to invoke constructor
                pg.computeLength(x1, y1, x2, y2);
             }

            //object for line comparision class
            LineComparision lcc = new LineComparision();

            //calling non-static method
            lcc.compareLines();
            
            

           




        }
    }
}
