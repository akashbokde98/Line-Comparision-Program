using System;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Compustation Program!");
            Program obj = new Program();
            double lenghtOfLine = obj.LengthofLine();
            Console.WriteLine("Length of a Line = " + lenghtOfLine);
        }
        public double LengthofLine()
        {
            Console.WriteLine("For Point 1");
            Console.WriteLine("Enter Value of X1-");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Y1-");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("For Point 2");
            Console.WriteLine("Enter Value of X2-");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Y2-");
            int y2 = int.Parse(Console.ReadLine());

            double v1 = Math.Pow((x2 - x1), 2);
            double v2 = Math.Pow((y2 - y1), 2);

            double length = Math.Sqrt(v1 + v2);

            return length;
        }
    }
}
