using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculate_Triangle_Area
{
    class Calculate_Triangle_Area
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = CalculateArea(a, b);
            Console.WriteLine(result);
        }
        private static double CalculateArea(double a, double b)
        {
            double area = (a * b) / 2D;
            return area;
        }
    }

}
