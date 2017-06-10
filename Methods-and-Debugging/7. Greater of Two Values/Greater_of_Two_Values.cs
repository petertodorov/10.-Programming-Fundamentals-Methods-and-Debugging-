using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greater_of_Two_Values
{
    class Greater_of_Two_Values
    {
        static void Main(string[] args)
        {
            string typeValue = Console.ReadLine();
            
            if (typeValue=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int resultInt =  GetMax(a,b);
                Console.WriteLine(resultInt);
            }
            else if (typeValue == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char resultChar = GetMax(a, b);
                Console.WriteLine(resultChar);
            }
            else if (typeValue == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string resultString = GetMax(a, b);
                Console.WriteLine(resultString);
            }
        }
        private static int GetMax(int a, int b)
        {
       
            int bigger = Math.Max(a, b);
            return bigger;
        }
        private static char GetMax(char a, char b)
        {
            int aTemp = Convert.ToInt32(a);
            int bTemp = Convert.ToInt32(b);
            int bigger = Math.Max(a, b);
            char result = Convert.ToChar(bigger);
            return result;
        }
        private static string GetMax(string a, string b)
        {
            string result = string.Empty;
            if (a.CompareTo(b)>0)
            {
                result = a;
            }
            else if (a.CompareTo(b) < 0)
            {
                result = b;
            }
            else
            {
                result = a;
            }
            return result;
        }
    }
}

