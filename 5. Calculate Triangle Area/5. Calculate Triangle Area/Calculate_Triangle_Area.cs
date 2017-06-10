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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double result = CalculateArea(a, b);
            Console.WriteLine(result);
        }
        private static double CalculateArea(int a, int b)
        {
            double area= (a * b) / 2D;
            return area;
        }
    }
}
