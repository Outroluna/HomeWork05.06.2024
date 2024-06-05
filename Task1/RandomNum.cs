using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rnd.Task1;

public static class RandomGeneration
{
    public static double RandDouble(double max, double min)
    {
        Random rnd = new Random();
        return rnd.NextDouble() * (max - min) + min;
    }
    public static int RandInt(int max, int min)
    {
        Random rnd = new Random();
        return rnd.Next(min, max);
    }
}



