using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    class LineComparision
    {
        public int X_One;
        public int X_Two;
        public int Y_One;
        public int Y_Two;
        public int S_One;
        public int S_Two;
        public int R_One;
        public int R_Two;
        public double LengthOfXY;
        public double LengthOfSR;
        public void lengthOFLine()
        {

            //Coodinates 1
            Console.WriteLine("Enter x, y co ordinates of the line 1 :");
            Console.WriteLine("Enter value X_One");
            X_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale X_Two");
            X_Two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y_One");
            Y_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y_Two");
            Y_Two = Convert.ToInt32(Console.ReadLine());

            //Coodinates 2
            Console.WriteLine("Enter x, y co ordinates of the line 2 :");
            Console.WriteLine("Enter value of S_One");
            S_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of S_Two");
            S_Two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R_One");
            R_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R_Two");
            R_Two = Convert.ToInt32(Console.ReadLine());

            //Calculating value of XY
            LengthOfXY = Math.Sqrt(Math.Pow((X_One - X_Two), 2) + Math.Pow((Y_Two - Y_One), 2));
            Console.WriteLine("Length of Value 1 is:: " + LengthOfXY);
            //Calculating value of SR
            LengthOfSR = Math.Sqrt(Math.Pow((S_Two - S_One), 2) + Math.Pow((R_Two - R_One), 2));
            Console.WriteLine("Length of Value 2 is: " + LengthOfSR);

        }
        public void functioncheckequallines()
        {
            bool equalToResult = LengthOfXY.Equals(LengthOfSR);

            if (equalToResult == false)
                Console.WriteLine("Therefore, Lines LengthOfXY and LengthOfSR are NOT Equal.");
            else
                Console.WriteLine("Therefore, Lines LengthOfXY and LengthOfSR are Equal.");
            Console.ReadKey();
        }
        public void functionCompare()
        {
            double Differene = LengthOfXY.CompareTo(LengthOfSR);
            if (Differene < 0)
                Console.WriteLine("Length of Line LengthOfXY is less than LengthOfSR.");
            if (Differene > 0)
                Console.WriteLine("Length of Line LengthOfXY is greater than LengthOfSR.");
            if (Differene == 0)
                Console.WriteLine("Both Lines are equal in Length.");
            Console.ReadKey();
        }

    }
}
