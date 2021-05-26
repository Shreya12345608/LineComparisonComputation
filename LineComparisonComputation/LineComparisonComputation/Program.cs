using System;


namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("... Welcome to Line Comparison Computation ... ");
            
            Console.WriteLine("Enter x, y coordinates of the line 1::");
            
            Console.WriteLine("X1");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            double Length = new double();
            Length = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of line 1 is:: " + Length);
            Console.ReadKey();
        }
    }

}
