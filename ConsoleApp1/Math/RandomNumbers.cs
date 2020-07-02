using System;

namespace ConsoleApp1.Math
{
    public class RandomNumbers
    {
        public double[] generateCentroids()
        {
            Random random = new Random();

            double[] resultArray = new double[2];
            resultArray[0] = random.NextDouble() + 1;
            resultArray[1] = random.NextDouble() + 1;

            return resultArray;
        }
    }
}