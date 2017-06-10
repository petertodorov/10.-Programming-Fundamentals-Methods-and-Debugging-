using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Power
{
    class Math_Power
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = CalculatePower(n, power);
            Console.WriteLine(result);
        }

        private static double CalculatePower(double n, int power)
        {
            double powered = Math.Pow(n, power);
            return powered;
        }
    }
}
