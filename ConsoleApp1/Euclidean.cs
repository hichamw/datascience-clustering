using System;

namespace ConsoleApp1
{
    public class Euclidean : IDistance
    {
        public float calculate(int[] x, int[] y)
        {
            var pointsSum = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                pointsSum += Math.Pow((x[i] - y[i]),2);
            }

            var result = Math.Sqrt(pointsSum);
            return (float) result;
        }
    }
}