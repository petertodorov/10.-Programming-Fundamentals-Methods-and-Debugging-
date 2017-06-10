using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Draw_a_Filled_Square
{
    class Draw_a_Filled_Square
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DrawStraightLine(n);
            DrawMiddlePart(n);
            DrawStraightLine(n);
        }

        private static void DrawMiddlePart(int n)
        {
            for (int j = 1; j < n - 1; j++)
            {
                Console.Write("-");
                for (int i = 0; i <= n - 2; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }            
        }

        private static void DrawStraightLine(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
