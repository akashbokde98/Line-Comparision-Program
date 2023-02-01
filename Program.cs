using System;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Compustation Program!");
            Program obj = new Program();
            obj.CompareTwoLines();
        }
        public void CompareTwoLines()
        {
            Console.WriteLine("For Line1 Point 1");
            Console.WriteLine("Enter Value of X1-");
            double x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Y1-");
            double y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("For Line1 Point 2");
            Console.WriteLine("Enter Value of X2-");
            double x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Y2-");
            double y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("For Line 2 Point 1");
            Console.WriteLine("Enter Value of X3-");
            double x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Y3-");
            double y3 = int.Parse(Console.ReadLine());

            Console.WriteLine("For Line 2 Point 2");
            Console.WriteLine("Enter Value of X4-");
            double x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Y4-");
            double y4 = int.Parse(Console.ReadLine());

            double v1 = Math.Pow((x2 - x1), 2);
            double v2 = Math.Pow((y2 - y1), 2);
            double v3 = Math.Pow((x4 - x3), 2);
            double v4 = Math.Pow((y4 - y3), 2);

            double length1 = Math.Sqrt(v1 + v2);
            double length2 = Math.Sqrt(v3 + v4);

            if (length1.Equals(length2))
            {
                Console.WriteLine("Line1 and Line2 are Equal and Preferable.");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("line1 is Greater than line2");
            }
            else
            {
                Console.WriteLine("Line1 is less than and Not Equal to Line2.");
            }
        }
    }
}
