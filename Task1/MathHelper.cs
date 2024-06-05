using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathH.Task1
{
    public static class MathHelper
    {
        public static int Factorial(int x)
        {
            int result = 1;
            for (var i = 1; i <= x; i++)
            { 
                result *= i;
            }
            return result;
        }

        public static int Exponentiation(int number, int power)
        {
            int result = 1;
            for (var i = 0; i < power; i++) 
            { 
                result*= number;
            }
            return result;
        }
        public static double RootCalculations(int number, int root)
        {
            return Math.Pow(number, 1.0 / root);
        }

    }
}
