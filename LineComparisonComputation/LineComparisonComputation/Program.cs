using System;


namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("... Welcome to Line Comparison Computation ... ");
            //Coodinates 1
            Console.WriteLine("Enter x, y co ordinates of the line 1 :");
            
            Console.WriteLine("Enter value X1");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale X2");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            //Coodinates 2

            Console.WriteLine("Enter x, y co ordinates of the line 2 :");

            Console.WriteLine("Enter value of S1");
            int S1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of S2");
            int S2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R1");
            int R1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R2");
            int R2 = Convert.ToInt32(Console.ReadLine());

            //Calculating value of XY

            double LengthOfXY = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Value 1 is:: " + LengthOfXY);
            
            //Calculating value of SR
            
            
            double LengthOfSR = Math.Sqrt(Math.Pow((S2 - S1), 2) + Math.Pow((R2 - R1), 2));
            Console.WriteLine("Length of Value 2 is: " + LengthOfSR);
          
            //Check LengthOfXY = LengthOfSR


            bool equalToResult = LengthOfXY.Equals(LengthOfSR);

            if (equalToResult == false)
            {
                Console.WriteLine("Therefore, Lines LengthOfXY and LengthOfSR are NOT Equal.");
            }
            else
            {
                Console.WriteLine("Therefore, Lines LengthOfXY and LengthOfSR are Equal.");
            }
            Console.ReadKey();
        }
    }

}
