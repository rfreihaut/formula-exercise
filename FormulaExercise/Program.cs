using System;

namespace FormulaExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            double d = GetRectangleArea(5,7);
            Console.WriteLine(d);

            double d2 = GetTriangleArea(3, 4);

            double d3 = GetTriangleArea(5, 4, 3);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            double d4 = PythagoreanFormula(6, 8);
            Console.WriteLine(d4);

            double d5 = GetCircleArea(5);
            Console.WriteLine(d5);

            double d6 = xpoints(0, 0);

            double d7 = ypoints(2, 4);

            Console.WriteLine("midpoint is =" + d6 + " ," + d7);

            double d8 = GetDistanceBetweenTwoPints(0, 0, 1, 1);

            Console.WriteLine("Length = " + d8);
  

        }

        public static double GetRectangleArea(double length, double height)
        {
            double result = length * height;
            return result;
        }

        public static double GetTriangleArea(double width, double height)
        {
            double result = width * height *.5;
            return result;
        }

        public static double GetTriangleArea(double side1, double side2, double side3)
        {
            double area = (side1 + side2 + side3) / 2;
            double result = area * (area - side1) * (area - side2) * (area - side3);
            
            return Math.Sqrt(result);
        }

        public static double PythagoreanFormula(double a, double b)
        {
            double aS = a * a;
            double bS = b * b;

            double total = aS + bS;
            return Math.Sqrt(total);
        }

        public static double GetCircleArea(double r)
        {
            double rsquared = r * r;

            double pi = Math.PI;

            double area = pi * rsquared;

            return area;
        }

        public static double xpoints(double x1, double x2)
        {
            double xmid = (x1 + x2) / 2.0;

            return xmid;
        }

        public static double ypoints(double y1, double y2)
        {
             
            double ymid = (y1 + y2) / 2.0;

            return ymid;
        }
         
           

        //    public Tuple<double, double> GetPoint()
        //{
        //    Tuple<double, double> coordinates = new Tuple<double, double>(1.5, 4);
        //    return coordinates;
        //}

        public static double GetDistanceBetweenTwoPints(double x1, double y1, double x2, double y2)
        {
            double deltaxsquared = (x1 - x2) * (x1 - x2);
            double deltaysquared = (y1 - y2) * (y1 - y2);

            double total = deltaxsquared + deltaysquared;

            double answer = Math.Sqrt(total);

            return answer;
        }
    }
}
